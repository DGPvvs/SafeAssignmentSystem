namespace SafeAssignmentSystem.Models.ChoisViewModels
{
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;

    public class ChoisUserAndMonthViewModel : ChoisAccountViewModel
    {
        /// <summary>
        /// Начален час на смяната
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true)]
        public string Month { get; set; } = null!;
    }
}
