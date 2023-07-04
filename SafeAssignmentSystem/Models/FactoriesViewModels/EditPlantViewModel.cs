namespace SafeAssignmentSystem.Models.FactoriesViewModels
{
    public class EditPlantViewModel : PlantViewModel
    {
        /// <summary>
        /// Идентификатор на инсталацията
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Комплекс към който се чесле инсталацията
        /// </summary>
        public string ComplexName { get; set; } = null!;
    }
}
