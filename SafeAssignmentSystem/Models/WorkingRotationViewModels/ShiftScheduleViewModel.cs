namespace SafeAssignmentSystem.Models.WorkingRotationViewModels
{
    using SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels;
    using System.ComponentModel.DataAnnotations;

	/// <summary>
	/// Модел на изгледа на смените на потребителя
	/// </summary>
	public class ShiftScheduleViewModel
    {
        /// <summary>
        /// Конструктор на модела на изгледа на смените на потребителя
        /// </summary>
        public ShiftScheduleViewModel()
        {
            this.UserShifts = new List<ShiftsViewModel>();
        }

        /// <summary>
        /// Име на акаунт на потребителя
        /// </summary>
        [Required]
        public string UserName { get; set; } = null!;

        /// <summary>
        /// Списък на смените на потребителя
        /// </summary>
        [Required]
        public IList<ShiftsViewModel> UserShifts { get; set; }
    }
}
