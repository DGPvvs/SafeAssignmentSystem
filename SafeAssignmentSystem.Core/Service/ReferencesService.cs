namespace SafeAssignmentSystem.Core.Service
{
	using Microsoft.EntityFrameworkCore;
	using SafeAssignmentSystem.Common.Enums;
	using SafeAssignmentSystem.Common.Exceptions;
	using SafeAssignmentSystem.Core.Contracts;
	using SafeAssignmentSystem.Core.Models.TransferModels.ReferencesTransferModels;
	using SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels;
	using SafeAssignmentSystem.DataBase.Data.Common;
	using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
	using SafeAssignmentSystem.DataBase.Data.DatabaseModels.SafeAssignmentDocumentModels;
	using SafeAssignmentSystem.DataBase.Data.FactoryModels;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;

	public class ReferencesService : IReferencesService
    {
        private readonly IRepository repo;
        private readonly IChoisPlantsService choisPlantsService;
		private readonly ISafeAssignmentService safeAssignmentService;

        public ReferencesService(
            IRepository repo,
            IChoisPlantsService choisPlantsService,
            ISafeAssignmentService safeAssignmentService)
        {
            this.repo = repo;
            this.choisPlantsService = choisPlantsService;
			this.safeAssignmentService = safeAssignmentService;
        }

        /// <summary>
        /// Имплементация на метод връщащ архивираните нарядите за технологична позиция
        /// </summary>
        /// <param name="positionId">Идентификатор на технологична позиция</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<AllSafeAssignmentArchivedTransferModel> GetAllArchivedSafeAssignmentTechnologicalPositionAsync(Guid positionId)
        {
			var result = await this.repo.AllReadonly<TechnologicalPosition>()
				.Where(tp => tp.Id.Equals(positionId))
				.Select(tp => new AllSafeAssignmentArchivedTransferModel()
				{
                    Complex = tp.Instalation.Complex.FullName,
                    Plant = tp.Instalation.FullName,
                    Position = tp.Name
                })
				.FirstOrDefaultAsync();

			if (result is null)
			{
				throw new TechnologicalPositionException();
			}

			var transfer = await this.safeAssignmentService.AllSafeAssigmentForPositionAndStatusAsync(positionId, StatusFlagsEnum.Archived);
            result.SafeAssignments = transfer;

			return result;
        }

        /// <summary>
        /// Имплементация на метод връщащ състоянието на технологичните позиции
        /// в инсталация с идентификатор plantId според критериите на filter
        /// </summary>
        /// <param name="plantId">Идентификатор на инсталация</param>
        /// <param name="filter"></param>
        /// <returns></returns>
        /// <exception cref="PlantNotFoundException"></exception>
        public async Task<PositionInPlantTransferModel> GetTechnologicalPositionConditionAsync(Guid plantId, FilterCriteria filter)
		{
			var plant = await this.repo.AllReadonly<PlantInstalation>()
				.Where(pi => pi.Id.Equals(plantId))
				.Select(pi => new PlantInstalation()
				{
					Id = pi.Id,
					FullName = pi.FullName,
					Complex = pi.Complex
				})
				.ToListAsync();

			if (plant.Count().Equals(0))
			{
				throw new PlantNotFoundException();
			}

			var positionsIds = await this.choisPlantsService.ChoicesAllPositionInPlantAsync(plantId);

			var result = new PositionInPlantTransferModel()
			{
				ComlpexFullName = plant.First().Complex.FullName,
				InstalationFullName = plant.First().FullName,
			};

			foreach (var positionId in positionsIds)
			{
				var position = await this.repo.GetByIdAsync<TechnologicalPosition>(positionId);

				var detailTransfer = new PositionDetailsTransferModel()
				{
					PositionId = position.Id,
					PositionName = position.Name,
					SafeAssignments = await this.repo.AllReadonly<SafeAssignmentDocument>()
						.Where(sa => sa.TechnologicalPositionId.Equals(position.Id)
							&& !sa.Status.Equals(StatusFlagsEnum.Archived))
						.Select(sa => new SafeAssignmentTransferModel()
						{
							Status = sa.Status
						})
						.ToListAsync()
				};

				result.Positions.Add(detailTransfer);
			}

			result.Positions = this.GetPositionsDetails(result.Positions, filter);

			return result;
		}

		private ICollection<PositionDetailsTransferModel> GetPositionsDetails(ICollection<PositionDetailsTransferModel> transfer, FilterCriteria filter)
		{
			switch (filter)
			{
				case FilterCriteria.UnderRepair:
					transfer = transfer.Where(p => !p.InWork).ToList();
					break;
				case FilterCriteria.NoVoltageApplied:
					transfer = transfer.Where(p => p.Opening > 0 || p.Closing > 0 || p.Required > 0).ToList();
					break;
			}

			return transfer;
		}
	}
}
