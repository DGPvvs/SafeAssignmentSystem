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
    using System.ComponentModel.Design;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ReferencesService : IReferencesService
    {
        private readonly IRepository repo;
        private readonly IChoisPlantsService choisPlantsService;

        public ReferencesService(
            IRepository repo,
            IChoisPlantsService choisPlantsService)
        {
            this.repo = repo;
            this.choisPlantsService = choisPlantsService;
        }

        public async Task<PositionInPlantTransferModel> GetTechnologicalPositionCondition(Guid plantId)
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

            return result;
        }
    }
}
