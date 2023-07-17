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

	public class SafeAssignmentController : BaseSafeAssignmentController
    {
		private readonly UserManager<ApplicationUser> userManager;
		private readonly IPlantsService plantsService;
		private readonly ISafeAssignmentService safeAssignmentService;

        public SafeAssignmentController(
			UserManager<ApplicationUser> userManager,
			IPlantsService plantsService,
            ISafeAssignmentService safeAssignmentService)
		{
			this.userManager = userManager;
			this.plantsService = plantsService;
			this.safeAssignmentService = safeAssignmentService;
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

		[Authorize(Roles = $"{Electrician}")]
		[HttpGet]
		public IActionResult OpeningSafeAssignment(Guid plantId)
		{
			var model = new SafeAssignmentOrderingViewModel()
			{

			};

			return View(model);
		}
	}
}
