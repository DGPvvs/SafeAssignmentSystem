namespace SafeAssignmentSystem.Models.AccountViewModels
{
    /// <summary>
    /// Модел на изгледа показващ потребителите
    /// </summary>
    public class AllUsersViewModel
    {
        /// <summary>
        /// Поле съдържащо идентификатора на потребител в модела за изгледа показващ потребителите
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Акаунт
        /// </summary>
        public string UserName { get; set; } = null!;
    }
}
