namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels;
    using System.Threading.Tasks;

    public interface IWorkingRotationService
    {
        public Task AddShiftAsync(ShiftTransferModel transfer);
    }
}
