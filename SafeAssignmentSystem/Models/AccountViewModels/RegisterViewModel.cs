using SafeAssignmentSystem.Models.CommonViewModels;
using System.ComponentModel.DataAnnotations;
using static SafeAssignmentSystem.Common.ModelsConstants.ViewModelConstants.ApplicationUserConstants;
using static SafeAssignmentSystem.Common.ModelsConstants.ViewModelConstants.ChangePasswordModelConstants;

namespace SafeAssignmentSystem.Models.AccountViewModels
{
    /// <summary>
    /// Модел кореспондиращ с изображението за регистрация на нов потребител
    /// </summary>
    public class RegisterViewModel
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public RegisterViewModel()
        {
            this.Instalations = new List<CheckBoxViewModel>();
            this.Roles = new List<KeyValuePairViewModel>();
        }

        /// <summary>
        /// Потребителско име
        /// </summary>
        [Required]
        public string UserName { get; set; } = null!;

        /// <summary>
        /// Собствено име на потребител
        /// </summary>        
        [Required]
        [StringLength(FirstName_Max_Length, MinimumLength = FirstName_Min_Length)]
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Фамилно име на потребител
        /// </summary>
        [Required]
        [StringLength(LastName_Max_Length, MinimumLength = LastName_Min_Length)]
        public string LastName { get; set; } = null!;

        /// <summary>
        /// Табелен номер на потребителя
        /// </summary>
        [Required]
        public int UserWorkNumber { get; set; }

        /// <summary>
        /// Нова парола
        /// </summary>
        [Required]
        [StringLength(New_Password_Max_Length,
            ErrorMessage = New_Password_Error_Message,
            MinimumLength = New_Password_Min_Length)]
        [DataType(DataType.Password)]
        [Display(Name = "Нова парола")]
        public string Password { get; set; } = null!;

        /// <summary>
        /// Потвърждение на новата парола
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Потвърждение на новата парола")]
        [Compare("Password", ErrorMessage = Confirm_Password_Error_Message)]
        public string ConfirmPassword { get; set; } = null!;

        /// <summary>
        /// Роля
        /// </summary>
        [Required]
        public string Role { get; set; } = null!;

        /// <summary>
        /// Списък с възможните инсталации
        /// </summary>
        public IList<CheckBoxViewModel> Instalations { get; set; }

        /// <summary>
        /// Списък с роли
        /// </summary>
        public IEnumerable<KeyValuePairViewModel> Roles { get; set; }
    }
}

