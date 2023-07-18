namespace SafeAssignmentSystem.Models.AccountViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class EditRegisterViewModel : RegisterViewModel
    {
        /// <summary>
        /// Идентификатор на потребител, който ще се редактира
        /// </summary>
        [Required]
        public Guid Id { get; set; }
    }
}
