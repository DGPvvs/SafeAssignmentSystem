namespace SafeAssignmentSystem.Models.WorkingRotationViewModels
{
    using SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels;
    using SafeAssignmentSystem.Models.CommonViewModels;
    using System.ComponentModel.DataAnnotations;

    public class CreateShiftScheduleViewModel
    {
        public CreateShiftScheduleViewModel()
        {
            this.UserShifts = new List<ShiftsTransferModel>();
            this.ShiftsNames = new List<KeyValuePairViewModel>();
        }

        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        public string UserFullName { get; set; } = null!;

        [Required]
        public string Month { get; set; } = null!;

        [Required]
        public int Year { get; set; }

        [Required]
        public List<ShiftsTransferModel> UserShifts { get; set; }

        [Required]
        public List<KeyValuePairViewModel> ShiftsNames { get; set; }
    }
}
