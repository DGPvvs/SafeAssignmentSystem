namespace SafeAssignmentSystem.Models.FactoriesViewModels
{
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
