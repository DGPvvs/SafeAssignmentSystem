﻿namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Core.Models.TransferModels;
    using SafeAssignmentSystem.Core.Models.TransferModels.UserTransferModels;
    using System;
    using System.Threading.Tasks;

    public interface IAccountService
    {
        public Task<StatusModel> EditAccount(RegisterUserTransferModel model, string AdministratorUserName);
        public Task<IEnumerable<UserTransferModel>> GetAllUsers(string currentUserName);
        public Task<IEnumerable<UserTransferModel>> GetAllUsersWhithRole(string currentUserName);
        public Task<bool> HasUserPremisionForPlant(Guid userId, Guid plantId);
        public Task<StatusModel> LoginPermissionAsync(UserTransferModel user);
        public Task<StatusModel> RegisterUserAsync(RegisterUserTransferModel model);
    }
}
