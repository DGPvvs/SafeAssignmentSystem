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
    using Microsoft.AspNetCore.Identity;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;

    /// <summary>
    /// Контролер менажиращ таблиците с комплекси, инсталации и технологични позиции
    /// </summary>
    public class PlantsController : BasePlantsController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IPlantsService plantsService;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="plantsService"></param>
        public PlantsController(
            UserManager<ApplicationUser> userManager,
            IPlantsService plantsService)
        {
            this.userManager = userManager;
            this.plantsService = plantsService;
        }

        /// <summary>
        /// Действие опериращо с изображението за създаване на комплекс
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ComplexCreate()
        {
            ComplexViewModel model = new ComplexViewModel();

            return this.View(model);
        }

        /// <summary>
        /// Действие валидиращо данните при създаването на комплекс.
        /// При коректни данни комплексът се създава.
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
        /// Действие изобразяващ всички неизтрити комплекси
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

        /// <summary>
        /// Get действие на изгледа за редакция на комплекс
        /// </summary>
        /// <param name="id">Идентификатор на комплекс</param>
        /// <returns></returns>
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

        /// <summary>
        /// Post действие на изгледа за редакция на комплекс
        /// </summary>
        /// <param name="model">Модел на данните за редакцията на комплекса</param>
        /// <returns></returns>
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

        /// <summary>
        /// Get действие на изгледа за изтриване на комплекс
        /// </summary>
        /// <param name="id">Идентификатор на комплекс</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> DelComplex(Guid id)
        {
            try
            {
                await this.plantsService.ChangeDeleteStatusComplexAsync(id, IsDeletedCondition.Deleted);

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

        /// <summary>
        /// Get действие на изгледа за визуализиране на всички изтрити комплекси
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Get действие на изгледа за възстановяване на изтрити комплекси
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> ComplexRecovery(Guid id)
        {
            try
            {
                await this.plantsService.ChangeDeleteStatusComplexAsync(id, IsDeletedCondition.NotDeleted);

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

        /// <summary>
        /// Get действие на изглеза за създаване на нови инсталации
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> PlantCreate()
        {
            var model = new PlantViewModel()
            {
                Complexes = await this.GetComplexPairAsync(IsDeletedCondition.NotDeleted)
            };

            return this.View(model);
        }

        /// <summary>
        /// Post действие на изглеза за създаване на нови инсталации
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get действие на изгледа за визуализиране на всички инсталации
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AllPlants()
        {
            var user = await this.userManager.FindByIdAsync(User.Id());
            var model = await this.plantsService.GetAllPlantsAsync(user.Id, IsAdminCondition.Is_Admin);

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

        /// <summary>
        /// Get action отговарящ за редакцията на инсталациите
        /// </summary>
        /// <param name="id">Идентификатор на инсталацията, която ще се редактира</param>
        /// <returns></returns>
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

        /// <summary>
        /// Post action отговарящ за редакцията на инсталация
        /// </summary>
        /// <param name="model">Модел на данните върнат от изображението</param>
        /// <returns></returns>
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

        /// <summary>
        /// Get действие на изгледа за създаване на нови технологични позиции
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> TechnologicalPositionCreate()
        {
            var model = new TechnologicalPositionViewModel()
            {
                Instalations = await this.GetInstalationsPairAsync(IsDeletedCondition.NotDeleted)
            };

            return this.View(model);
        }


        /// <summary>
        /// Post действие на изгледа за създаване на нови технологични позиции
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get действие на изгледа за извеждане на всички технологични позиции в инсталация
        /// с идентификатор plantId 
        /// </summary>
        /// <param name="plantId">Идентификатор на инсталация</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AllTechnologicalPosition(Guid plantId)
        {
            var model = await this.plantsService.GetAllPositionInPlantByIdAsync(plantId, IsDeletedCondition.NotDeleted);

            var viewModel = model.
                Select(tp => new EditTechnologicalPositionViewModel()
                {
                    Id = tp.Id,
                    Name = tp.Name,
                    PlantName = tp.InstalationName,
                    ComplexName = tp.ComplexName                    
                })
                .OrderBy(c => c.Name)
                .ToList();

            return this.View(viewModel);
        }

        /// <summary>
        /// Get действие на изгледа за редактиране на технологични позиции
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> EditTechnologicalPosition(Guid id)
        {
            var transfer = await this.plantsService.GetTechnologicalPositionByIdAsync(id);

            if (transfer is null)
            {
                this.TempData[Error_Message] = TechnologicalPosition_Find_Fail;
                ModelState.AddModelError(string.Empty, TechnologicalPosition_Find_Fail);
                return this.RedirectToAction("AllTechnologicalPosition", "Plants");
            }

            var model = new EditTechnologicalPositionViewModel()
            {
                Id = transfer.Id,
                Name = transfer.Name,
                ComplexName = transfer.ComplexName,
                InstalationId = transfer.InstalationId,
                PlantName = transfer.InstalationName,
                Instalations = await this.GetInstalationsPairAsync(IsDeletedCondition.NotDeleted)
            };

            return this.View(model);
        }

        /// <summary>
        /// Post действие на изгледа за редакция на технологични позиции
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> EditTechnologicalPosition(EditTechnologicalPositionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Instalations = await this.GetInstalationsPairAsync(IsDeletedCondition.NotDeleted);
                return this.View(model);
            }

            TechnologicalPositionTransferModel transfer = new TechnologicalPositionTransferModel()
            {
                Id = model.Id,
                Name = model.Name,
                InstalationId = model.InstalationId
            };

            try
            {
                await this.plantsService.EditTechnologicalPositionAsync(transfer);

                this.TempData[Success_Message] = Edit_TechnologicalPosition_Add_Success;
                return this.RedirectToAction("Index", "Home");
            }
            catch (IdentityЕxception ie)
            {
                this.TempData[Error_Message] = ie.Message;
                ModelState.AddModelError(string.Empty, ie.Message);
                model.Instalations = await this.GetInstalationsPairAsync(IsDeletedCondition.NotDeleted);
                return View(model);
            }
            catch (Exception)
            {
                this.TempData[Error_Message] = TechnologicalPosition_Find_Fail;
                ModelState.AddModelError(string.Empty, TechnologicalPosition_Find_Fail);
                model.Instalations = await this.GetInstalationsPairAsync(IsDeletedCondition.NotDeleted);
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
            var user = await this.userManager.FindByIdAsync(User.Id());
            var instalations = await this.plantsService.GetAllPlantsAsync(user.Id, IsAdminCondition.Is_Admin);

            return instalations
                .OrderBy(c => c.Name)
                .Select(c => new KeyValuePairViewModel(c.Id, c.Name))
                .ToList();
        }
    }
}
