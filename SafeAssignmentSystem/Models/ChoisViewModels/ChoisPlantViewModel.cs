namespace SafeAssignmentSystem.Models.ChoisViewModels
{
    using SafeAssignmentSystem.Models.FactoriesViewModels;

    /// <summary>
    /// Модел на изгледа за избор на инсталации
    /// </summary>
    public class ChoisPlantViewModel
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ChoisPlantViewModel()
        {
            this.Plants = new List<EditPlantViewModel>();
        }

        /// <summary>
        /// Идентификатор на инсталация
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Път за редиректване след избор на инсталация
        /// </summary>
        public string RedirectRouter { get; set; } = null!;

        /// <summary>
        /// Колекция с модели на изгледа на инсталациите
        /// </summary>
        public IEnumerable<EditPlantViewModel> Plants { get; set; } = null!;
    }
}
