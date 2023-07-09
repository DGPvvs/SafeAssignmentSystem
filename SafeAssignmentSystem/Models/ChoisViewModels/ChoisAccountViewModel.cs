namespace SafeAssignmentSystem.Models.ChoisViewModels
{
    using SafeAssignmentSystem.Models.AccountViewModels;

    public class ChoisAccountViewModel
    {
        public ChoisAccountViewModel()
        {
            this.AllUsers = new List<AllUsersViewModel>();
        }

        public Guid Id { get; set; }

        public string RedirectController { get; set; } = null!;

        public string RedirectAction { get; set; } = null!;

        public IEnumerable<AllUsersViewModel> AllUsers { get; set; } = null!;
    }
}
