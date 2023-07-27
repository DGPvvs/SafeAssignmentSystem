namespace SafeAssignmentSystem.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using SafeAssignmentSystem.Common.Enums;
    using SafeAssignmentSystem.Common.Exceptions;
    using SafeAssignmentSystem.Controllers.AbstractControlers;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.TransferModels.ReferencesTransferModels;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using SafeAssignmentSystem.Models.ReferenceViewModel;
    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;

    public class ReferenceController : BaseReferenceController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IPlantsService plantsService;
        private readonly IReferencesService referencesService;

        public ReferenceController(
            UserManager<ApplicationUser> userManager,
            IPlantsService plantsService,
            IReferencesService referencesService)
        {
            this.userManager = userManager;
            this.plantsService = plantsService;
            this.referencesService = referencesService;
        }

        /// <summary>
        /// Get метод връщащ информация за всички технологични позиции
        /// в инсталацията с идентификатор plantId 
        /// </summary>
        /// <param name="plantId">Идентификатор на инсталация</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AllTechnologicalPositionCondition(Guid plantId)
        {
            try
            {
                var transfer = await this.referencesService.GetTechnologicalPositionConditionAsync(plantId, FilterCriteria.All);
                var model = this.SetInModel(transfer);

				return View(model);
			}
            catch (PlantNotFoundException pnfe)
            {
                this.TempData[Error_Message] = pnfe.Message;
                return this.RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
				this.TempData[Error_Message] = e.Message;
				return this.RedirectToAction("Index", "Home");
			}            
        }

		/// <summary>
		/// Get метод връщащ информация за всички технологични позиции в ремонт
		/// в инсталацията с идентификатор plantId
		/// </summary>
		/// <param name="plantId">Идентификатор на инсталация</param>
		/// <returns></returns>
		[HttpGet]
        public async Task<IActionResult> AllTechnologicalPositionUnderRepair(Guid plantId)
        {
            try
            {
                var transfer = await this.referencesService.GetTechnologicalPositionConditionAsync(plantId, FilterCriteria.UnderRepair);
                var model = this.SetInModel(transfer);

                return View(model);
            }
            catch (PlantNotFoundException pnfe)
            {
                this.TempData[Error_Message] = pnfe.Message;
                return this.RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                this.TempData[Error_Message] = e.Message;
                return this.RedirectToAction("Index", "Home");
            }
        }

        /// <summary>
        /// Метод запълващ детайлите за технологичната позиция
        /// </summary>
        /// <param name="transfer">Трансферен модел с детайлите за технологичните позиции</param>
        /// <returns></returns>
        private PositionsInPlantViewModel SetInModel(PositionInPlantTransferModel transfer)
        {
			var model = new PositionsInPlantViewModel();

			model.ComplexFullName = transfer.ComlpexFullName;
			model.PlantFullName = transfer.InstalationFullName;

			model.PositionsDetail = transfer.Positions
				.Select(p => new PositionDetailViewModel()
				{
					Name = p.PositionName,
					InWork = p.InWork,
					Created = p.Created,
					Opening = p.Opening,
					Closing = p.Closing,
					Required = p.Required,
				})
				.ToList();

            return model;
		}
	}
}
