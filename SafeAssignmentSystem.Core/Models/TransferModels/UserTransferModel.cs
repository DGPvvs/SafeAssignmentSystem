namespace SafeAssignmentSystem.Core.Models.TransferModels
{
    /// <summary>
    /// Трансферен модел на потребител
    /// </summary>
    public class UserTransferModel
    {
        /// <summary>
        /// Име на акаунт на потребител
        /// </summary>
        public string UserName { get; set; } = null!;

        /// <summary>
        /// Първо име на потребител
        /// </summary>
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Фамилно име на потребител
        /// </summary>
        public string LastName { get; set; } = null!;
    }
}
