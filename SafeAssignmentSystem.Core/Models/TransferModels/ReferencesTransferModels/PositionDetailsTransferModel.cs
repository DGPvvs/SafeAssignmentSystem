namespace SafeAssignmentSystem.Core.Models.TransferModels.ReferencesTransferModels
{
    using SafeAssignmentSystem.Common.Enums;
    using SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Трансферен модел пренасящ детайли за технологичната позиция при подготвяне на справки
    /// </summary>
    public class PositionDetailsTransferModel
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public PositionDetailsTransferModel()
        {
            this.SafeAssignments = new List<SafeAssignmentTransferModel>();
        }

        /// <summary>
        /// Идентификатор на технологична позиция
        /// </summary>
        public Guid PositionId { get; set; }

        /// <summary>
        /// Име на позицията
        /// </summary>
        public string PositionName { get; set; } = null!;

		/// <summary>
		/// Статус: В работа
		/// </summary>
		public bool InWork => this.SafeAssignments.Count.Equals(0) ? true : false;

        /// <summary>
        /// Брой заведени наряди
        /// </summary>
        public int Created => this.SafeAssignments.Where(sa => sa.Status.HasFlag(StatusFlagsEnum.Created)).Count();

		/// <summary>
		/// Брой действащи наряди
		/// </summary>
		public int Opening => this.SafeAssignments.Where(sa => sa.Status.HasFlag(StatusFlagsEnum.Opening)).Count();

		/// <summary>
		/// Брой закрити наряди
		/// </summary>
		public int Closing => this.SafeAssignments.Where(sa => sa.Status.HasFlag(StatusFlagsEnum.Closing)).Count();

        /// <summary>
        /// Брой заявки за подаване на напрежение
        /// </summary>
        public int Required => this.SafeAssignments.Where(sa => sa.Status.HasFlag(StatusFlagsEnum.Required)).Count();

        /// <summary>
        /// Колекция, съдържаща нарядите към технологичната позиция
        /// </summary>
        public ICollection<SafeAssignmentTransferModel> SafeAssignments { get; set; }
    }
}
