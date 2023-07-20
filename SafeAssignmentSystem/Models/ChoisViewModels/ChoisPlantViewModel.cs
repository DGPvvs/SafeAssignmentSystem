namespace SafeAssignmentSystem.Models.ChoisViewModels
{
    using SafeAssignmentSystem.Models.FactoriesViewModels;

    public class ChoisPlantViewModel
    {
        public ChoisPlantViewModel()
        {
            this.Plants = new List<EditPlantViewModel>();
        }

        public Guid Id { get; set; }

        public string RedirectRouter { get; set; } = null!;

        public IEnumerable<EditPlantViewModel> Plants { get; set; } = null!;
    }
}
