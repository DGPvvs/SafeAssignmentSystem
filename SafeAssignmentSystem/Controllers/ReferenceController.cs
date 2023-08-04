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
    using System;
    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;

    /// <summary>
    /// Контролер менажиращ извеждането на списъци
    /// </summary>
    public class ReferenceController : BaseReferenceController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IPlantsService plantsService;
        private readonly IReferencesService referencesService;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="plantsService"></param>
        /// <param name="referencesService"></param>
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
        /// Get метод връщащ информация за всички технологични позиции в
		/// в инсталацията с идентификатор plantId, на които не е подадено напрежение
        /// </summary>
        /// <param name="plantId">Идентификатор на инсталация</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AllTechnologicalPositionNoVoltageApplied(Guid plantId)
        {
            try
            {
                var transfer = await this.referencesService.GetTechnologicalPositionConditionAsync(plantId, FilterCriteria.NoVoltageApplied);
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
        /// Get метод връщащ информация за всички наряди за технологична позиция
        /// </summary>
        /// <param name="positionId">Идентификатор на технологична позиция</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AllSafeAssignment(Guid positionId)
        {
            try
            {
                var transfer = await this.referencesService.GetAllArchivedSafeAssignmentTechnologicalPositionAsync(positionId);

                var model = new AllArchiveViewModel()
                {
                    Complex = transfer.Complex,
                    Plant = transfer.Plant,
                    Position = transfer.Position
                };

                foreach (var safeAssignment in transfer.SafeAssignments.OrderBy(sa => sa.Number))
                {
                    var archiveSafeAssignment = new ArchivedSafeAssignmentPositionViewModels()
                    {
                        Number = safeAssignment.Number,
                        OpeningDate = safeAssignment.OpeningDate?.ToString() ?? null,
                        OpeningTime = safeAssignment.OpeningTime?.ToString() ?? null,
                        ClosingDate= safeAssignment.ClosingDate?.ToString() ?? null,
                        ClosingTime = safeAssignment.ClosingTime?.ToString() ?? null
                    };

                    var user = await this.userManager.FindByIdAsync(safeAssignment.ElectricianAppliedVoltageId.ToString());
                    archiveSafeAssignment.ElectricianAppliedVoltage = user.LastName;

                    user = await this.userManager.FindByIdAsync(safeAssignment.ЕlectricianOpeningOrderId.ToString());
                    archiveSafeAssignment.ЕlectricianOpeningOrder = user.LastName;

                    user = await this.userManager.FindByIdAsync(safeAssignment.ЕlectricianClosingOrderId.ToString());
                    archiveSafeAssignment.ЕlectricianClosingOrder = user.LastName;

                    user = await this.userManager.FindByIdAsync(safeAssignment.PersonRequestedOpeningOrderId.ToString());
                    archiveSafeAssignment.PersonRequestedOpeningOrder = user.LastName;

                    user = await this.userManager.FindByIdAsync(safeAssignment.PersonRequestedVoltageSupplyId.ToString());
                    archiveSafeAssignment.PersonRequestedVoltageSupply = user.LastName;

                    model.SafeAssignments.Add(archiveSafeAssignment);
                }


                return this.View(model);
            }
            catch (TechnologicalPositionException tpe)
            {
                this.TempData[Error_Message] = tpe.Message;
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
