﻿namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels;
    using System.Threading.Tasks;
    /// <summary>
    /// Интерфейс деклариращ методи за менажиране на комплекси, инсталации и технологично оборудване
    /// </summary>
    public interface IPlantsService
    {
        /// <summary>
        /// Деклариране на метода за добавяне на комплекси
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task AddComplexAsync(ComplexTransferModel model);

        /// <summary>
        /// дефиниране на метод връщащ колекция от трансферни модели с всички комплекси
        /// </summary>
        /// <param name="isDel"></param>
        /// <returns></returns>
        public Task<IEnumerable<ComplexTransferModel>> GetAllComplexAsync(bool isDel);

        public Task<ComplexTransferModel> GetComplexByIdAsync(Guid id);

        public Task EditComplexAsync(ComplexTransferModel model);

		public Task ChangeDeleteStatusComplexAsync(Guid id, bool isDel);

        public Task AddPlantAsync(PlantTransferModel model);

        public Task<IEnumerable<PlantTransferModel>> GetAllPlantsAsync(Guid userId, bool isAdmin, bool isActive = true);

        public Task<PlantTransferModel> GetPlantByIdAsync(Guid id);

        public Task EditPlantAsync(PlantTransferModel model);

        public Task AddTechnologicalPositionAsync(TechnologicalPositionTransferModel model);

        public Task<IEnumerable<TechnologicalPositionTransferModel>> GetAllPositionInPlantByIdAsync(Guid id, bool isDel);

        public Task<TechnologicalPositionTransferModel> GetTechnologicalPositionByIdAsync(Guid id);

        public Task EditTechnologicalPositionAsync(TechnologicalPositionTransferModel model);

        public Task<PlantTransferModel> GetPlantByPositionId(Guid positionId);
    }
}
