namespace SafeAssignmentSystem.Controllers
{
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Identity;
	using Microsoft.AspNetCore.Mvc;
	using SafeAssignmentSystem.Controllers.AbstractControlers;
	using SafeAssignmentSystem.Core.Contracts;
	using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
	using SafeAssignmentSystem.Models.CommonViewModels;
	using SafeAssignmentSystem.Models.SafeAssignmentViewModels;
	using static SafeAssignmentSystem.Common.Notification.ConditionConstants;
	using static SafeAssignmentSystem.Common.Notification.RoleConstants;

	
	public class SafeAssignmentController : BaseSafeAssignmentController
    {
		private readonly UserManager<ApplicationUser> userManager;
		private readonly IPlantsService plantsService;

		public SafeAssignmentController(
			UserManager<ApplicationUser> userManager,
			IPlantsService plantsService)
		{
			this.userManager = userManager;
			this.plantsService = plantsService;
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
		public IActionResult CreateSafeAssignment(SafeAssignmentOrderingViewModel model)
		{
			model = new SafeAssignmentOrderingViewModel();

			return View(model);
		}

		[Authorize(Roles = $"{Electrician}")]
		[HttpGet]
		public IActionResult OpeningSafeAssignment(Guid plantId)
		{
			var model = new SafeAssignmentOrderingViewModel();

			return View(model);
		}
	}
}
