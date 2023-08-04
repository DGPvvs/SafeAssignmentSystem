namespace SafeAssignmentSystem.Models.ChoisViewModels
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Модел на изгледа връщащ датата на смяната
    /// </summary>
    public class ChoisUserAndMonthViewModel : ChoisAccountViewModel
    {
        /// <summary>
        /// Дата на смяната
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public string Date { get; set; } = null!;
    }
}