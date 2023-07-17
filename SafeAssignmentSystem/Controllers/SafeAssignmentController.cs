namespace SafeAssignmentSystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SafeAssignmentSystem.Controllers.AbstractControlers;
    using SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels;
    using SafeAssignmentSystem.Models.SafeAssignmentViewModels;

    public class SafeAssignmentController : BaseSafeAssignmentController
    {
        [HttpGet]
        public IActionResult CreateSafeAssignment(Guid plantId)
        {
            var model = new SafeAssignmentOrderingViewModel();

            return View(model);
        }
    }
}
