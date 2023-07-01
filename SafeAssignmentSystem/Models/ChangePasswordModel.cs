namespace SafeAssignmentSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    using static SafeAssignmentSystem.Common.ModelsConstants.ViewModelConstants.ChangePasswordModelConstants;

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Текуща парола")]
        public string OldPassword { get; set; } = null!;

        [Required]
        [StringLength(New_Password_Max_Length,
            ErrorMessage = New_Password_Error_Message,
            MinimumLength = New_Password_Min_Length)]
        [DataType(DataType.Password)]
        [Display(Name = "Нова парола")]
        public string NewPassword { get; set; } = null!;

        [DataType(DataType.Password)]
        [Display(Name = "Потвърждение на новата парола")]
        [Compare("NewPassword", ErrorMessage = Confirm_Password_Error_Message)]
        public string ConfirmPassword { get; set; } = null!;
    }
}
