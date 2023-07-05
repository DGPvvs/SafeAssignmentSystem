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
    using static SafeAssignmentSystem.Common.Notification.ConditionConstants;

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

                this.TempData[Success_Message] = New_Complex_Add_Success;
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

        /// <summary>
        /// Екшън изобразяващ всички неизтрити комплекси
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AllComplex()
        {
            var model = await this.plantsService.GetAllComplexAsync(IsDeletedCondition.NotDeleted);

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
                await this.plantsService.DeleteComplexAsync(id, IsDeletedCondition.Deleted);

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
            var model = await this.plantsService.GetAllComplexAsync(IsDeletedCondition.Deleted);

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
                await this.plantsService.DeleteComplexAsync(id, IsDeletedCondition.NotDeleted);

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
            var model = new PlantViewModel()
            {
                Complexes = await this.GetComplexPairAsync(IsDeletedCondition.NotDeleted)
            };

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> PlantCreate(PlantViewModel model)
        {
            model.Complexes = await this.GetComplexPairAsync(IsDeletedCondition.NotDeleted);

            if (!this.ModelState.IsValid)
            {                
                return this.View(model);
            }

            PlantTransferModel transfer = new PlantTransferModel()
            {
                Name = model.Name,
                FullName = model.FullName,
                ComplexId = model.ComplexId
            };

            try
            {
                await this.plantsService.AddPlantAsync(transfer);

                this.TempData[Success_Message] = New_Plant_Add_Success;
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
                this.TempData[Error_Message] = New_Plant_Add_Fail;
                ModelState.AddModelError(string.Empty, New_Complex_Add_Fail);
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> AllPlants()
        {
            var model = await this.plantsService.GetAllPlantsAsync(IsDeletedCondition.NotDeleted);

            var viewModel = model.
                Select(c => new EditPlantViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    FullName = c.FullName,
                    ComplexName = c.ComplexName
                })
                .OrderBy(c => c.Name)
                .ToList();

            return this.View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> EditPlant(Guid id)
        {            
            var transfer = await this.plantsService.GetPlantByIdAsync(id);

            if (transfer is null)
            {
                this.TempData[Error_Message] = Plant_Find_Fail;
                ModelState.AddModelError(string.Empty, Plant_Find_Fail);
                return this.RedirectToAction("AllPlants", "Plants");
            }

            var model = new EditPlantViewModel()
            {
                Id = transfer.Id,
                Name = transfer.Name,
                FullName = transfer.FullName,
                ComplexName = transfer.ComplexName,
                Complexes = await this.GetComplexPairAsync(IsDeletedCondition.NotDeleted)
            };

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditPlant(EditPlantViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Complexes = await this.GetComplexPairAsync(IsDeletedCondition.NotDeleted);
                return this.View(model);
            }

            PlantTransferModel transfer = new PlantTransferModel()
            {
                Id = model.Id,
                Name = model.Name,
                FullName = model.FullName,
                ComplexId = model.ComplexId
            };

            try
            {
                await this.plantsService.EditPlantAsync(transfer);

                return this.RedirectToAction("AllPlants", "Plants");
            }
            catch (IdentityЕxception ie)
            {
                this.TempData[Error_Message] = ie.Message;
                ModelState.AddModelError(string.Empty, ie.Message);
                model.Complexes = await this.GetComplexPairAsync(IsDeletedCondition.NotDeleted);
                return View(model);
            }
            catch (Exception)
            {
                this.TempData[Error_Message] = Plant_Find_Fail;
                ModelState.AddModelError(string.Empty, Plant_Find_Fail);
                model.Complexes = await this.GetComplexPairAsync(IsDeletedCondition.NotDeleted);
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> TechnologicalPositionCreate()
        {
            var model = new TechnologicalPositionViewModel()
            {
                Instalations = await this.GetInstalationsPairAsync(IsDeletedCondition.NotDeleted)
            };

            return this.View(model);
        }


        [HttpPost]
        public async Task<IActionResult> TechnologicalPositionCreate(TechnologicalPositionViewModel model)
        {
            model.Instalations = await this.GetInstalationsPairAsync(IsDeletedCondition.NotDeleted);

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            TechnologicalPositionTransferModel transfer = new TechnologicalPositionTransferModel()
            {
                Name = model.Name,
                InstalationId = model.InstalationId
            };

            try
            {
                await this.plantsService.AddTechnologicalPositionAsync(transfer);

                this.TempData[Success_Message] = New_TechnologicalPosition_Add_Success;
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
                this.TempData[Error_Message] = New_TechnologicalPosition_Add_Fail;
                ModelState.AddModelError(string.Empty, New_Complex_Add_Fail);
                return View(model);
            }
        }        

        private async Task<IEnumerable<KeyValuePairViewModel>> GetComplexPairAsync(bool isDel)
        {
            var complexes = await this.plantsService.GetAllComplexAsync(isDel);

            return complexes
                .OrderBy (c => c.Name)
                .Select(c => new KeyValuePairViewModel(c.Id, c.Name))                
                .ToList();
        }

        private async Task<IEnumerable<KeyValuePairViewModel>> GetInstalationsPairAsync(bool isDel)
        {
            var instalations = await this.plantsService.GetAllPlantsAsync(isDel);

            return instalations
                .OrderBy(c => c.Name)
                .Select(c => new KeyValuePairViewModel(c.Id, c.Name))
                .ToList();
        }
    }
}
