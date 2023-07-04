namespace SafeAssignmentSystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SafeAssignmentSystem.Common.Exceptions;
    using SafeAssignmentSystem.Common.Exeptions;
    using SafeAssignmentSystem.Controllers.AbstractControlers;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels;
    using SafeAssignmentSystem.Models.CommonViewModels;
    using SafeAssignmentSystem.Models.FactoriesViewModels;

    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;

    /// <summary>
    /// Контролер менажиращ таблиците с комплекси, инсталации и технологични позиции
    /// </summary>
    public class PlantsController : BasePlantsController
    {
        private readonly IPlantsService plantsService;

        public PlantsController(IPlantsService plantsService)
        {
            this.plantsService = plantsService;
        }

        /// <summary>
        /// Екшън опериращ с изображението за създаване на комплекс
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ComplexCreate()
        {
            ComplexViewModel model = new ComplexViewModel();

            return this.View(model);
        }

        /// <summary>
        /// Екшън валидиращ данните при създаването на комплекс
        /// </summary>
        /// <param name="model">Модел на данните при създаване на комплекс</param>
        /// <returns></returns>
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
            var model = await this.plantsService.GetAllComplexAsync(false);

            var viewModel = model.
                Select(c => new EditComplexViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    FullName = c.FullName,
                    CountPlant = c.PlantInstalations.Count
                })
                .OrderBy(c => c.Name)
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
                return this.RedirectToAction("AllComplex", "Plants");
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

                return this.RedirectToAction("AllComplex", "Plants");
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
        public async Task<IActionResult> DelComplex(Guid id)
        {
            try
            {
                await this.plantsService.DeleteComplexAsync(id, true);

                return this.RedirectToAction("AllComplex", "Plants");
            }
            catch (NotEmptyException nee)
            {
                this.TempData[Error_Message] = nee.Message;
                ModelState.AddModelError(string.Empty, nee.Message);
                return this.RedirectToAction("AllComplex", "Plants");
            }
            catch (Exception)
            {
                this.TempData[Error_Message] = Complex_Delete_Fail;
                ModelState.AddModelError(string.Empty, Complex_Delete_Fail);
                return this.RedirectToAction("AllComplex", "Plants");
            }
        }

        [HttpGet]
        public async Task<IActionResult> AllDeletedComplex()
        {
            var model = await this.plantsService.GetAllComplexAsync(true);

            var viewModel = model.
                Select(c => new EditComplexViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    FullName = c.FullName,
                    CountPlant = c.PlantInstalations.Count
                })
                .OrderBy(c => c.Name)
                .ToList();

            return this.View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> ComplexRecovery(Guid id)
        {
            try
            {
                await this.plantsService.DeleteComplexAsync(id, false);

                return this.RedirectToAction("AllComplex", "Plants");
            }
            catch (NotEmptyException nee)
            {
                this.TempData[Error_Message] = nee.Message;
                ModelState.AddModelError(string.Empty, nee.Message);
                return this.RedirectToAction("AllComplex", "Plants");
            }
            catch (Exception)
            {
                this.TempData[Error_Message] = Complex_Undelete_Fail;
                ModelState.AddModelError(string.Empty, Complex_Undelete_Fail);
                return this.RedirectToAction("AllComplex", "Plants");
            }
        }

        [HttpGet]
        public async Task<IActionResult> PlantCreate()
        {
            var complexes = await this.plantsService.GetAllComplexAsync(false);

            var keysComplexes = complexes
                .Select(c => new KeyValuePairViewModel(c.Id, c.Name))
                .ToList();

            var model = new PlantViewModel()
            {
                Complexes = keysComplexes
            };

            return this.View(model);
        }
    }
}
