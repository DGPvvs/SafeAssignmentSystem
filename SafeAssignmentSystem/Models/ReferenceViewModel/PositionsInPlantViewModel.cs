namespace SafeAssignmentSystem.Models.ReferenceViewModel
{
    /// <summary>
    /// Модел на изгледа за технологичните позиции в инсталация
    /// </summary>
    public class PositionsInPlantViewModel
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public PositionsInPlantViewModel()
        {
            this.PositionsDetail = new List<PositionDetailViewModel>();
        }

        /// <summary>
        /// Пълно име на инсталацията
        /// </summary>
        public string PlantFullName { get; set; } = null!;

        /// <summary>
        /// Пълно име на комплекса
        /// </summary>
        public string ComplexFullName { get; set; } = null!;

        /// <summary>
        /// Колекция съдържаща описание на статуса на технологичните позиции
        /// </summary>
        public ICollection<PositionDetailViewModel> PositionsDetail { get; set; }
    }
}
