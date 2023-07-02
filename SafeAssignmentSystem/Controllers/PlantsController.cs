namespace SafeAssignmentSystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SafeAssignmentSystem.Common.Exeptions;
    using SafeAssignmentSystem.Controllers.AbstractControlers;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels;
    using SafeAssignmentSystem.Models.FactoriesViewModels;

    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;

    public class PlantsController : BasePlantsController
    {
        private readonly IPlantsService plantsService;

        public PlantsController(IPlantsService plantsService)
        {
            this.plantsService = plantsService;
        }

        [HttpGet]
        public IActionResult ComplexCreate()
        {
            ComplexViewModel model = new ComplexViewModel();

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ComplexCreate(ComplexViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            ComplexTransferModel transfer = new ComplexTransferModel()
            {
                Name = model.Name,
                FullName = model.FullName,
                IsDeleted = false
            };

            try
            {
                await this.plantsService.AddComplexAsync(transfer);

                return RedirectToAction("Index", "Home");
            }
            catch (IdentityЕxception ie)
            {
                this.TempData[Error_Message] = ie.Message;
                ModelState.AddModelError(string.Empty, ie.Message);
                return View(model);
            }
            catch (Exception)
            {
                this.TempData[Error_Message] = New_Complex_Add_Fail;
                ModelState.AddModelError(string.Empty, New_Complex_Add_Fail);
                return View(model);
            }
        }
    }
}
