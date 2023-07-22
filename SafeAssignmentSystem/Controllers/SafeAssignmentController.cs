namespace SafeAssignmentSystem.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using SafeAssignmentSystem.Controllers.AbstractControlers;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using SafeAssignmentSystem.Models.CommonViewModels;
    using SafeAssignmentSystem.Models.SafeAssignmentViewModels;

    using static SafeAssignmentSystem.Common.Notification.ConditionConstants;
    using static SafeAssignmentSystem.Common.Notification.RoleConstants;
    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Common.Enums;
    using System.Security.Cryptography.Xml;
    using SafeAssignmentSystem.Common.Exceptions;

    public class SafeAssignmentController : BaseSafeAssignmentController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IPlantsService plantsService;
        private readonly ISafeAssignmentService safeAssignmentService;
        private readonly IAccountService accountService;

        public SafeAssignmentController(
            UserManager<ApplicationUser> userManager,
            IPlantsService plantsService,
            ISafeAssignmentService safeAssignmentService,
            IAccountService accountService)
        {
            this.userManager = userManager;
            this.plantsService = plantsService;
            this.safeAssignmentService = safeAssignmentService;
            this.accountService = accountService;
        }

        [Authorize(Roles = $"{Operator}")]
        [HttpGet]
        public async Task<IActionResult> CreateSafeAssignment(Guid plantId)
        {
            var positions = await this.plantsService.GetAllPositionInPlantByIdAsync(plantId, IsDeletedCondition.NotDeleted);
            var plant = await this.plantsService.GetPlantByIdAsync(plantId);

            var model = new SafeAssignmentOrderingViewModel()
            {
                PlantInstalationName = plant.FullName,
                PlantInstalationId = plant.Id,
                TechnologicalPositions = positions.Select(tp => new KeyValuePairViewModel(tp.Id, tp.Name)).ToList()
            };

            return View(model);
        }

        [Authorize(Roles = $"{Operator}")]
        [HttpPost]
        public async Task<IActionResult> CreateSafeAssignment(SafeAssignmentOrderingViewModel model)
        {
            var user = await this.userManager.FindByIdAsync(User.Id());

            if (user is null)
            {
                this.TempData[Error_Message] = User_Not_Found;
                return this.RedirectToAction("Index", "Home");
            }

            if (!(await this.accountService.HasUserPremisionForPlant(user.Id, model.PlantInstalationId)))
            {
                this.TempData[Error_Message] = User_Not_Permision;
                return this.RedirectToAction("Index", "Home");
            }

            var transfer = new SafeAssignmentTransferModel()
            {
                Number = model.Number,
                TechnologicalPositionId = model.TechnologicalPositionId,
                PersonRequestedOpeningOrderId = user.Id,
                Status = StatusFlagsEnum.Created
            };

            StatusModel result = await this.safeAssignmentService.CreateSafeAssignment(transfer);

            if (result.Success)
            {
                this.TempData[Success_Message] = result.Description;
            }
            else
            {
                this.TempData[Error_Message] = result.Description;
            }

            return this.RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// Get действие зареждащо модела на изображението за откпиване на наряди 
        /// </summary>
        /// <param name="positionId">Идентификатор на технологигна позиция, за която е заведен наряд</param>
        /// <returns></returns>
        [Authorize(Roles = $"{Electrician}")]
        [HttpGet]
        public async Task<IActionResult> OpeningSafeAssignment(Guid positionId)
        {
            var model = new List<SafeAssignmentOpeningViewModel>();

            try
            {
                var transferModel = await this.safeAssignmentService.AllCreatedSafeAssigmentForPosition(positionId);
                var positionTransfer = await this.plantsService.GetTechnologicalPositionByIdAsync(positionId);

                foreach (var transfer in transferModel)
                {
                    var viewModel = new SafeAssignmentOpeningViewModel();

                    var user = await this.userManager.FindByIdAsync(transfer.PersonRequestedOpeningOrderId.ToString());
                    viewModel.PersonRequestedOpeningOrder = user.LastName;

                    viewModel.Id = transfer.Id;
                    viewModel.Number = transfer.Number;
                    viewModel.TechnologicalPositionName = positionTransfer.Name;
                    viewModel.PlantInstalationName = positionTransfer.InstalationName;
                    viewModel.ComplexName = positionTransfer.ComplexName;                    

                    model.Add(viewModel);
                }

                model = model.OrderBy(sao => sao.Number).ToList();                
            }
            catch(TechnologicalPositionException tpe)
            {
                this.TempData[Error_Message] = tpe.Message;                
            }
            catch (Exception)
            {
                this.TempData[Error_Message]= Operation_Fail;
            }
            finally
            {
                this.RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}
