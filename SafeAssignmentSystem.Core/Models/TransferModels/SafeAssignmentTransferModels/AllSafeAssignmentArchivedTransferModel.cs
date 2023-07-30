namespace SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels
{
    using System.Collections.Generic;

    /// <summary>
    /// Трансферен модел за всички архивирани наряди за технологична позиция
    /// </summary>
    public class AllSafeAssignmentArchivedTransferModel
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public AllSafeAssignmentArchivedTransferModel()
        {
            this.SafeAssignments = new List<SafeAssignmentTransferModel>();
        }

        /// <summary>
        /// Име на комплекс
        /// </summary>
        public string Complex { get; set; } = null!;

        /// <summary>
        /// Име на инсталация
        /// </summary>
        public string Plant { get; set; } = null!;

        /// <summary>
        /// Име на технологичната позиция
        /// </summary>
        public string Position { get; set; } = null!;

        /// <summary>
        /// Колекция с наряди за позицията
        /// </summary>
        public IEnumerable<SafeAssignmentTransferModel> SafeAssignments { get; set; }

    }
}
