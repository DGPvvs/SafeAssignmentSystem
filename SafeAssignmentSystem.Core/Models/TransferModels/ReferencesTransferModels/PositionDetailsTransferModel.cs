namespace SafeAssignmentSystem.Core.Models.TransferModels.ReferencesTransferModels
{
    using SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Трансферен модел пренасящ детайли за технологичната позиция при подготвяне на справки
    /// </summary>
    public class PositionDetailsTransferModel
    {
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
        /// Колекция, съдържаща нарядите към технологичната позиция
        /// </summary>
        public ICollection<SafeAssignmentTransferModel> SafeAssignments { get; set; }
    }
}
