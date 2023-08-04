using System.ComponentModel.DataAnnotations;

using static SafeAssignmentSystem.Common.ModelsConstants.ViewModelConstants.ChangePasswordModelConstants;

namespace SafeAssignmentSystem.Models.AccountViewModels
{
    /// <summary>
    /// Модел на изображението за редакция на потребителста парола
    /// </summary>
    public class EditPasswordViewModel
    {
        /// <summary>
        /// Акаунт на потребител
        /// </summary>
        public string? UserName { get; set; }

        /// <summary>
        /// Поле държащо новата парола в модела за промяна на паролите
        /// </summary>
        [Required]
        [StringLength(New_Password_Max_Length,
            ErrorMessage = New_Password_Error_Message,
            MinimumLength = New_Password_Min_Length)]
        [DataType(DataType.Password)]
        [Display(Name = "Нова парола")]
        public string NewPassword { get; set; } = null!;

        /// <summary>
        /// Потвърждение на новата парола
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Потвърждение на новата парола")]
        [Compare("NewPassword", ErrorMessage = Confirm_Password_Error_Message)]
        public string ConfirmPassword { get; set; } = null!;
    }
}
