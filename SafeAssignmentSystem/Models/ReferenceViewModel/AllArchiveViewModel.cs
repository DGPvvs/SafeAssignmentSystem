namespace SafeAssignmentSystem.Models.ReferenceViewModel
{
    /// <summary>
    /// Модел на изгледа на списъка за всички архивни наряди
    /// </summary>
    public class AllArchiveViewModel
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public AllArchiveViewModel()
        {
            this.SafeAssignments = new List<ArchivedSafeAssignmentPositionViewModels>();
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
        public IList<ArchivedSafeAssignmentPositionViewModels> SafeAssignments { get; set; }
    }
}
