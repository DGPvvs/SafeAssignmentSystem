namespace SafeAssignmentSystem.Models.ReferenceViewModel
{
    public class PositionsInPlantViewModel
    {
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
