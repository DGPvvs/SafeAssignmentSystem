namespace SafeAssignmentSystem.Models.AccountViewModels
{
    public class AllUsersViewModel
    {
        /// <summary>
        /// Поле съдържащо идентификатора на потребител в модела за изгледа показващ потребителите
        /// </summary>
        public Guid Id { get; set; }

        public string UserName { get; set; } = null!;
    }
}
