namespace SafeAssignmentSystem.Models.ChoisViewModels
{
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;

    /// <summary>
    /// Модел на изгледа за избор на акаунт
    /// </summary>
    public class ChoisAccountViewModel
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ChoisAccountViewModel()
        {
            this.AllUsers = new List<KeyValuePair<string, string>>();
        }

        /// <summary>
        /// Потребителско име на потребител
        /// </summary>
        public string User { get; set; } = null!;

        /// <summary>
        /// Име на контролера за редиректване
        /// </summary>
        public string RedirectController { get; set; } = null!;

        /// <summary>
        /// Действие на редиректването
        /// </summary>
        public string RedirectAction { get; set; } = null!;

        /// <summary>
        /// Колекция с потребителските имена и имената на потребителите
        /// </summary>
        public IEnumerable<KeyValuePair<string, string>> AllUsers { get; set; } = null!;
    }
}
