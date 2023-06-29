namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Core.Models.TransferModels;
    using System.Threading.Tasks;

    public interface IAccountService
    {
        public Task<StatusUserModel> LoginPermissionAsync(UserTransferModel user);
    }
}
