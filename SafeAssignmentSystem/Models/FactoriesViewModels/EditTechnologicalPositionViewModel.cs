namespace SafeAssignmentSystem.Models.FactoriesViewModels
{
    public class EditTechnologicalPositionViewModel : TechnologicalPositionViewModel
    {
        /// <summary>
        /// Идентификатор на технологичната позиция
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Инсталация към който се чесли технологичната позиция
        /// </summary>
        public string PlantName { get; set; } = null!;
    }
}
