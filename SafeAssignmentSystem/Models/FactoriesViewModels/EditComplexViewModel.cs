namespace SafeAssignmentSystem.Models.FactoriesViewModels
{
    /// <summary>
    /// Модел на изгледа за комплекс
    /// </summary>
    public class EditComplexViewModel : ComplexViewModel
    {
        /// <summary>
        /// Идентификатор на комплекса
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Брой инсталации свързани с комплекса
        /// </summary>
        public int CountPlant { get; set; }
    }
}
