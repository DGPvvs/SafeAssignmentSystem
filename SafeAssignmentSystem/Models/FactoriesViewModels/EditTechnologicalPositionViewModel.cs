namespace SafeAssignmentSystem.Models.FactoriesViewModels
{
    /// <summary>
    /// Модел на ижгледа за редактиране на технологична позиция
    /// </summary>
    public class EditTechnologicalPositionViewModel : TechnologicalPositionViewModel
    {
        /// <summary>
        /// Идентификатор на технологичната позиция
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Инсталация към който се числи технологичната позиция
        /// </summary>
        public string PlantName { get; set; } = null!;

        /// <summary>
        /// Комплекс към който се числи инсталацията
        /// </summary>
        public string ComplexName { get; set; } = null!;
    }
}
