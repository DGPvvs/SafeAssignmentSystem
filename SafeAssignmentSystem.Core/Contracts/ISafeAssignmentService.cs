namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels;
    using System;
    using System.Security.Cryptography.Xml;
    using System.Threading.Tasks;

    public interface ISafeAssignmentService
    {
        public Task<IEnumerable<SafeAssignmentTransferModel>> AllCreatedSafeAssigmentForPosition(Guid positionId);

        /// <summary>
        /// Декларация на метод завеждащ наряд за позиция, указана в transfer 
        /// </summary>
        /// <param name="transfer">Транспортен модел на наряда</param>
        /// <returns></returns>
        public Task<StatusModel> CreateSafeAssignment(SafeAssignmentTransferModel transfer);
    }
}
