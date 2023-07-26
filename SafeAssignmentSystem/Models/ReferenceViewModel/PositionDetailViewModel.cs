namespace SafeAssignmentSystem.Models.ReferenceViewModel
{
    /// <summary>
    /// Визуален модел на детайлите за техтологичната позиция
    /// </summary>
    public class PositionDetailViewModel
    {
        /// <summary>
        /// Име на технологичната позиция
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Статус: В работа
        /// </summary>
        public bool InWork { get; set; }

        /// <summary>
        /// Брой заведени наряди
        /// </summary>
        public int Created { get; set; }

        /// <summary>
        /// Брой действащи наряди
        /// </summary>
        public int Opening { get; set; }

        /// <summary>
        /// Брой закрити наряди
        /// </summary>
        public int Closing { get; set; }

        /// <summary>
        /// Брой заявки за подаване на напрежение
        /// </summary>
        public int Required { get; set; }
    }
}
