namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.Common.Enums;
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Интерфейс дефиниращ сървис манипулиращ с данните при работа с наряди
    /// </summary>
    public interface ISafeAssignmentService
    {
        /// <summary>
        /// Декларация на метод връщащ всички заведени наряди за технологична позиция
        /// </summary>
        /// <param name="positionId">Идентификатор на технологична позиция</param>
        /// <param name="status">Идентификатор на статус на наряда</param>
        /// <returns></returns>
        public Task<IEnumerable<SafeAssignmentTransferModel>> AllSafeAssigmentForPositionAndStatusAsync(Guid positionId, StatusFlagsEnum status);

        /// <summary>
        /// Декларация на метод създаващ заявка за подаване на напрежение
        /// за технологична позиция с идентификатор positionId
        /// и вдигащ статус StatusFlagsEnum.Archived на закритите наряди
        /// за указаната позиция
        /// </summary>
        /// <param name="id">Идентификатор на потребител</param>
        /// <param name="positionId">Идентификатор на позиция</param>
        /// <returns></returns>
        public Task<StatusModel> AppliedSafeAssignmentAsync(Guid id, Guid positionId);

        /// <summary>
        /// Декларация на метод закриващ наряд с идентификатор safeAssignmentId
        /// Наряда се закрива от потребител с идентификатор userId 
        /// </summary>
        /// <param name="safeAssignmentId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<StatusModel> ClosingSafeAssignmentAsync(Guid safeAssignmentId, Guid userId);

		/// <summary>
		/// Декларация на метод завеждащ наряд за позиция, указана в transfer 
		/// </summary>
		/// <param name="transfer">Транспортен модел на наряда</param>
		/// <returns></returns>
		public Task<StatusModel> CreateSafeAssignmentAsync(SafeAssignmentTransferModel transfer);

		/// <summary>
		/// Декларация на метод връщащ наряд с идентификатор safeAssignmentId
		/// </summary>
		/// <param name="safeAssignmentId">Идентификатор на наряд</param>
		/// <returns></returns>
		public Task<SafeAssignmentTransferModel> GetSafeAssignmentByIdAsync(Guid safeAssignmentId);

		/// <summary>
		/// Декларация на метод откриващ наряд с идентификатор safeAssignmentId
		/// Наряда се открива от потребител с идентификатор userId 
		/// </summary>
		/// <param name="safeAssignmentId">Идентификатор на наряд</param>
		/// <param name="userId">Идентификатор на потребител откриващ наряда</param>
		/// <returns></returns>
		public Task<StatusModel> OpeningSafeAssignmentAsync(Guid safeAssignmentId, Guid userId);

        /// <summary>
		/// Декларация на метод създаващ заявка за подаване на напрежение 
		/// за технологична позиция с идентификатор positionId
		/// и вдигащ статус StatusFlagsEnum.Required на закритите наряди
		/// за указаната позиция
		/// </summary>
		/// <param name="positionId">Идентификатор на позиция</param>
		/// <param name="id">Идентификатор на потребител</param>
		/// <returns></returns>
		public Task<StatusModel> RequestedSafeAssignmentAsync(Guid id, Guid positionId);
    }
}
