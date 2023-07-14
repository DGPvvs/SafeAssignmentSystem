namespace SafeAssignmentSystem.Models.WorkingRotationViewModels
{
    using SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels;
    using System.ComponentModel.DataAnnotations;

    public class ShiftScheduleViewModel
    {
        public ShiftScheduleViewModel()
        {
            this.UserShifts = new List<ShiftsViewModel>();
        }

        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        public IList<ShiftsViewModel> UserShifts { get; set; }
    }
}
