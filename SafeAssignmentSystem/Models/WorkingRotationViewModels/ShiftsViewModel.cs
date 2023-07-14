namespace SafeAssignmentSystem.Models.WorkingRotationViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class ShiftsViewModel
    {
        public ShiftsViewModel()
        {
            this.ShiftId = Guid.Empty;
            this.ShiftName = string.Empty;
        }

        [Required]
        public string Date { get; set; } = null!;

        public string ShiftName { get; set; }

        [Required]
        public Guid ShiftId { get; set; }
    }
}
