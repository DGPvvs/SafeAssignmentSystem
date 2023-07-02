﻿namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels;
    using System.Threading.Tasks;

    public interface IPlantsService
    {
        public Task AddComplexAsync(ComplexTransferModel model);

        public Task<IEnumerable<ComplexTransferModel>> GetAllComplexAsync();

        public Task<ComplexTransferModel> GetComplexByIdAsync(Guid id);

        public Task EditComplexAsync(ComplexTransferModel model);
	}
}
