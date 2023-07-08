namespace SafeAssignmentSystem.Models.AccountViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [UIHint("hidden")]
        public string ReturnUrl { get; set; } = null!;
    }
}
