namespace SafeAssignmentSystem.Models.ChoisViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class ChoisUserAndMonthViewModel : ChoisAccountViewModel
    {
        /// <summary>
        /// Начален час на смяната
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public string Date { get; set; } = null!;
    }
}