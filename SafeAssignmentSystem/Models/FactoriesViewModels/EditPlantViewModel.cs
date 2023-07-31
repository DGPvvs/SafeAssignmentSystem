namespace SafeAssignmentSystem.Models.FactoriesViewModels
{
    /// <summary>
    /// Модел на изгледа за редакция на инсталация 
    /// </summary>
    public class EditPlantViewModel : PlantViewModel
    {
        /// <summary>
        /// Идентификатор на инсталацията
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Комплекс към който се чесли инсталацията
        /// </summary>
        public string ComplexName { get; set; } = null!;
    }
}
