﻿namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels;
    using System.Threading.Tasks;

    public interface IPlantsService
    {
        public Task AddComplexAsync(ComplexTransferModel model);

        public Task<IEnumerable<ComplexTransferModel>> GetAllComplexAsync(bool isDel);

        public Task<ComplexTransferModel> GetComplexByIdAsync(Guid id);

        public Task EditComplexAsync(ComplexTransferModel model);

		public Task DeleteComplexAsync(Guid id, bool isDel);

        public Task AddPlantAsync(PlantTransferModel model);

        public Task<IEnumerable<PlantTransferModel>> GetAllPlantsAsync(bool isDel);
        public Task<PlantTransferModel> GetPlantByIdAsync(Guid id);

        public Task EditPlantAsync(PlantTransferModel model);
    }
}
