namespace SafeAssignmentSystem.Models.WorkingRotationViewModels
{
    public class ShiftsViewModel
    {
        public ShiftsViewModel()
        {
            this.ShiftId = Guid.Empty;
            this.ShiftName = string.Empty;
        }

        public DateOnly Date { get; set; }

        public string ShiftName { get; set; }

        public Guid ShiftId { get; set; }
    }
}
