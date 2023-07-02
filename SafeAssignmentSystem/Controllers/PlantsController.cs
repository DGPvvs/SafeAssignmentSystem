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

        [HttpGet]
        public async Task<IActionResult> AllComplex()
        {
            var model = await this.plantsService.GetAllComplexAsync();

            var viewModel = model.
                Select(c => new EditComplexViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    FullName = c.FullName,
                    CountPlant = c.PlantInstalations.Count
                })
                .ToList();

            return this.View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> EditComplex(Guid id)
        {
            var transfer = await this.plantsService.GetComplexByIdAsync(id);

            if (transfer is null)
            {
                this.TempData[Error_Message] = Complex_Find_Fail;
                ModelState.AddModelError(string.Empty, Complex_Find_Fail);
                return this.RedirectToAction("Index", "Home");
            }

            var model = new EditComplexViewModel()
            {
                Id = transfer.Id,
                Name = transfer.Name,
                FullName = transfer.FullName
            };

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditComplex(EditComplexViewModel model)
        {
			if (!ModelState.IsValid)
			{
				return this.View(model);
			}

			ComplexTransferModel transfer = new ComplexTransferModel()
            {
                Id = model.Id,
                Name = model.Name,
                FullName = model.FullName
            };

			try
			{
                await this.plantsService.EditComplexAsync(transfer);

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

        [HttpPost]
        public async Task<IActionResult> DeleteComplex(Guid id)
        {
            return this.RedirectToAction("Index", "Home");
        }
    }
}
