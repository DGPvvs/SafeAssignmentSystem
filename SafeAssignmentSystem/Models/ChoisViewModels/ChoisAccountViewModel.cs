namespace SafeAssignmentSystem.Models.ChoisViewModels
{
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;

    public class ChoisAccountViewModel
    {
        public ChoisAccountViewModel()
        {
            this.AllUsers = new List<KeyValuePair<string, string>>();
        }

        public string User { get; set; } = null!;

        public string RedirectController { get; set; } = null!;

        public string RedirectAction { get; set; } = null!;

        public IEnumerable<KeyValuePair<string, string>> AllUsers { get; set; } = null!;
    }
}
