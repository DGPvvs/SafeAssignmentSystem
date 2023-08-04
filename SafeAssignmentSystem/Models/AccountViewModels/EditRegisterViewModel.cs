namespace SafeAssignmentSystem.Models.AccountViewModels
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Модел на изгледа за редакция на потребител
    /// </summary>
    public class EditRegisterViewModel : RegisterViewModel
    {
        /// <summary>
        /// Идентификатор на потребител, който ще се редактира
        /// </summary>
        [Required]
        public Guid Id { get; set; }
    }
}
