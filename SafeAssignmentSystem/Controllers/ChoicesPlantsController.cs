namespace SafeAssignmentSystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Routing;
    using SafeAssignmentSystem.Common.Notification;
    using SafeAssignmentSystem.Controllers.AbstractControlers;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels;
    using SafeAssignmentSystem.Models.ChoisViewModels;
    using SafeAssignmentSystem.Models.FactoriesViewModels;
    using System;
    using static SafeAssignmentSystem.Common.Notification.ConditionConstants;
    using static System.Collections.Specialized.BitVector32;

    public class ChoicesPlantsController : BaseChoicesPlantsController
    {
        private readonly IPlantsService plantsService;
        private readonly IChoisPlantsService choisPlantsService;

        public ChoicesPlantsController(
            IPlantsService plantsService,
            IChoisPlantsService choisPlantsService)
        {
            this.plantsService = plantsService;
            this.choisPlantsService = choisPlantsService;
        }

        [HttpGet]
        public async Task<IActionResult> ChoisPlant(string controller, string action, string data)
        {
            var plants = await this.plantsService.GetAllPlantsAsync(IsDeletedCondition.NotDeleted);
            var s = data.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var model = new ChoisPlantViewModel()
            {
                RedirectAction = s[1],
                RedirectController = s[0],
                Plants = plants.Select(p => new EditPlantViewModel()
                {
                    Id = p.Id,
                    Name = p.Name                   
                })
                .ToList()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ChoisPlant(ChoisPlantViewModel model)
        {
            var plants = await this.plantsService.GetAllPlantsAsync(IsDeletedCondition.NotDeleted);

            if (!this.ModelState.IsValid)
            {
                model.Plants = plants.Select(p => new EditPlantViewModel()
                {
                    Id = p.Id,
                    Name = p.Name
                })
                .ToList();

                return View(model);
            }

            return RedirectToAction(model.RedirectAction, model.RedirectController, new { @id = model.Id });
        }
    }
}
