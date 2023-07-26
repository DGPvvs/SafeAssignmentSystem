namespace SafeAssignmentSystem.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using SafeAssignmentSystem.Common.Enums;
    using SafeAssignmentSystem.Common.Exceptions;
    using SafeAssignmentSystem.Controllers.AbstractControlers;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using SafeAssignmentSystem.Models.ReferenceViewModel;
    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;

    public class ReferenceController : BaseReferenceController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IPlantsService plantsService;
        private readonly IReferencesService referencesService;

        public ReferenceController(
            UserManager<ApplicationUser> userManager,
            IPlantsService plantsService,
            IReferencesService referencesService)
        {
            this.userManager = userManager;
            this.plantsService = plantsService;
            this.referencesService = referencesService;
        }

        [HttpGet]
        public async Task<IActionResult> AllTechnologicalPositionCondition(Guid plantId)
        {
            var model = new PositionsInPlantViewModel();

            try
            {
                var transfer = await this.referencesService.GetTechnologicalPositionCondition(plantId);

                model.ComplexFullName = transfer.ComlpexFullName;
                model.PlantFullName = transfer.InstalationFullName;

                model.PositionsDetail = transfer.Positions
                    .Select(p => new PositionDetailViewModel()
                    {
                        Name = p.PositionName,
                        InWork = p.SafeAssignments.Count.Equals(0) ? true : false,
                        Created = p.SafeAssignments.Where(sa => sa.Status.HasFlag(StatusFlagsEnum.Created)).Count(),
                        Opening = p.SafeAssignments.Where(sa => sa.Status.HasFlag(StatusFlagsEnum.Opening)).Count(),
                        Closing = p.SafeAssignments.Where(sa => sa.Status.HasFlag(StatusFlagsEnum.Closing)).Count(),
                        Required = p.SafeAssignments.Where(sa => sa.Status.HasFlag(StatusFlagsEnum.Required)).Count(),
                    })
                    .ToList();

            }
            catch (PlantNotFoundException pnfe)
            {
                this.TempData[Error_Message] = pnfe.Message;
                return this.RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {

                throw;
            }

            return View(model);
        }
    }
}
