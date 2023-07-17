namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels;
    using System.Threading.Tasks;

    public interface ISafeAssignmentService
    {
        public Task<StatusModel> CreateSafeAssignment(SafeAssignmentTransferModel transfer);
    }
}
