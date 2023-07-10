namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels;
    using System.Threading.Tasks;

    public interface IPlantsService
    {
        public Task AddComplexAsync(ComplexTransferModel model);

        public Task<IEnumerable<ComplexTransferModel>> GetAllComplexAsync(bool isDel);

        public Task<ComplexTransferModel> GetComplexByIdAsync(Guid id);

        public Task EditComplexAsync(ComplexTransferModel model);

		public Task ChangeDeleteStatusComplexAsync(Guid id, bool isDel);

        public Task AddPlantAsync(PlantTransferModel model);

        public Task<IEnumerable<PlantTransferModel>> GetAllPlantsAsync(bool isDel);

        public Task<PlantTransferModel> GetPlantByIdAsync(Guid id);

        public Task EditPlantAsync(PlantTransferModel model);

        public Task AddTechnologicalPositionAsync(TechnologicalPositionTransferModel model);

        public Task<IEnumerable<TechnologicalPositionTransferModel>> GetAllPositionInPlantByIdAsync(Guid id, bool isDel);

        public Task<TechnologicalPositionTransferModel> GetTechnologicalPositionByIdAsync(Guid id);

        public Task EditTechnologicalPositionAsync(TechnologicalPositionTransferModel model);
    }
}
