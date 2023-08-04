namespace SafeAssignmentSystem.Models.ChoisViewModels
{
    using SafeAssignmentSystem.Models.FactoriesViewModels;

    /// <summary>
    /// Модел на изгледа за избор на технологична позиция
    /// </summary>
    public class ChoisTechnologicalPositionViewModel
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ChoisTechnologicalPositionViewModel()
        {
            this.TechnologicalPositions = new List<EditTechnologicalPositionViewModel>();
        }

        /// <summary>
        /// Идентификатор на избраната технологична позиция
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Поле съдържащо информация за препратка към следващо действие
        /// </summary>
        public string? Redirection { get; set; }

        /// <summary>
        /// Колекция от модели на технологични позиции
        /// </summary>
        public IEnumerable<EditTechnologicalPositionViewModel> TechnologicalPositions { get; set; }
    }
}
