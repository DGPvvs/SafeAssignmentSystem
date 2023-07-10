namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels;
    using System;
    using System.Threading.Tasks;

    public interface IWorkingRotationService
    {
        public Task AddShiftAsync(ShiftTransferModel transfer);
        public Task EditShiftAsync(ShiftTransferModel transfer);
        public Task<IEnumerable<ShiftTransferModel>> GetAllShiftAsync();
        public Task<ShiftTransferModel> GetShiftByIdAsync(Guid id);
    }
}
