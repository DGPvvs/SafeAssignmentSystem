namespace SafeAssignmentSystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SafeAssignmentSystem.Controllers.AbstractControlers;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Models.WorkingRotationViewModels;

    public class WorkingRotationController : BaseWorkingRotationController
    {
        private readonly IWorkingRotationService workingRotationService;

        public WorkingRotationController(IWorkingRotationService workingRotationService)
        {
            this.workingRotationService = workingRotationService;
        }

        [HttpGet]
        public IActionResult ShiftCreate()
        {
            var model = new WorkingShiftViewModel();

            return this.View(model);
        }

        [HttpPost]
        public IActionResult ShiftCreate(WorkingShiftViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }


            return this.RedirectToAction("Index", "Home");
        }
    }
}
