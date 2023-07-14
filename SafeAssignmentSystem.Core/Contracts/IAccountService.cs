namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Core.Models.TransferModels;
    using SafeAssignmentSystem.Core.Models.TransferModels.UserTransferModels;
    using System.Threading.Tasks;

    public interface IAccountService
    {
        public Task<IEnumerable<UserTransferModel>> GetAllUsers(string currentUserName);
        public Task<IEnumerable<UserTransferModel>> GetAllUsersWhithRole(string currentUserName);
        public Task<StatusModel> LoginPermissionAsync(UserTransferModel user);
        public Task<StatusModel> RegisterUserAsync(RegisterUserTransferModel model);
    }
}
