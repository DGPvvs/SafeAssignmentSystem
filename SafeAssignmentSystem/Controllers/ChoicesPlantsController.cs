namespace SafeAssignmentSystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SafeAssignmentSystem.Controllers.AbstractControlers;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Models.ChoisViewModels;
    using SafeAssignmentSystem.Models.FactoriesViewModels;
    using System;
    using static SafeAssignmentSystem.Common.Notification.ConditionConstants;

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

        [HttpGet]
        public async Task<IActionResult> ChoisAccount(string controller, string action, string data)
        {

        }
    }
}
