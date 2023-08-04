namespace SafeAssignmentSystem.Models.AccountViewModels
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Модел на изгледа за логване на потребител
    /// </summary>
    public class LoginViewModel
    {
        /// <summary>
        /// Потребителско име на потребител
        /// </summary>
        [Required]
        public string UserName { get; set; } = null!;

        /// <summary>
        /// Парола на потребител
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        /// <summary>
        /// 
        /// </summary>
        [UIHint("hidden")]
        public string ReturnUrl { get; set; } = null!;
    }
}
