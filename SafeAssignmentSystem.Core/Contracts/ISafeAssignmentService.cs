namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.Common.Enums;
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels;
    using System;
    using System.Security.Cryptography.Xml;
    using System.Threading.Tasks;

    public interface ISafeAssignmentService
    {
        /// <summary>
        /// Декларация на метод връщащ всички заведени наряди за технологична позиция
        /// </summary>
        /// <param name="positionId">Идентификатор на технологична позиция</param>
        /// <returns></returns>
        public Task<IEnumerable<SafeAssignmentTransferModel>> AllSafeAssigmentForPositionAndStatus(Guid positionId, StatusFlagsEnum status);

		/// <summary>
		/// Декларация на метод закриващ наряд с идентификатор safeAssignmentId
		/// Наряда се закрива от потребител с идентификатор userId 
		/// </summary>
		/// <param name="safeAssignmentId"></param>
		/// <param name="userId"></param>
		/// <returns></returns>
		public Task<StatusModel> ClosingSafeAssignment(Guid safeAssignmentId, Guid userId);

		/// <summary>
		/// Декларация на метод завеждащ наряд за позиция, указана в transfer 
		/// </summary>
		/// <param name="transfer">Транспортен модел на наряда</param>
		/// <returns></returns>
		public Task<StatusModel> CreateSafeAssignment(SafeAssignmentTransferModel transfer);

		/// <summary>
		/// Декларация на метод връщащ наряд с идентификатор safeAssignmentId
		/// </summary>
		/// <param name="safeAssignmentId">Идентификатор на наряд</param>
		/// <returns></returns>
		public Task<SafeAssignmentTransferModel> GetSafeAssignmentById(Guid safeAssignmentId);

		/// <summary>
		/// Декларация на метод откриващ наряд с идентификатор safeAssignmentId
		/// Наряда се открива от потребител с идентификатор userId 
		/// </summary>
		/// <param name="safeAssignmentId">Идентификатор на наряд</param>
		/// <param name="userId">Идентификатор на потребител откриващ наряда</param>
		/// <returns></returns>
		public Task<StatusModel> OpeningSafeAssignment(Guid safeAssignmentId, Guid userId);

        /// <summary>
		/// Декларация на метод създаващ заявка за подаване на напрежение 
		/// за технологична позиция с идентификатор positionId
		/// и вдигащ статус StatusFlagsEnum.Required на закритите наряди
		/// за указаната позиция
		/// </summary>
		/// <param name="positionId">Идентификатор на позиция</param>
		/// <param name="id">Идентификатор на потребител</param>
		/// <returns></returns>
		public Task<StatusModel> RequestedSafeAssignment(Guid id, Guid positionId);
    }
}
