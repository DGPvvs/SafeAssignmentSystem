namespace SafeAssignmentSystem.Models.WorkingRotationViewModels
{
    using SafeAssignmentSystem.Models.CommonViewModels;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Модел на изображението на сменните графици
    /// </summary>
    public class CreateShiftScheduleViewModel
    {
        /// <summary>
        /// Конструктор на модела на изображението за създаване на сменен график
        /// </summary>
        public CreateShiftScheduleViewModel()
        {
            this.UserShifts = new List<ShiftsViewModel>();
            this.ShiftsNames = new List<KeyValuePairViewModel>();
        }

        /// <summary>
        /// Име на акаунт на потребителя
        /// </summary>
        [Required]
        public string UserName { get; set; } = null!;

        /// <summary>
        /// Пълно име на потребителя
        /// </summary>
        [Required]
        public string UserFullName { get; set; } = null!;

        /// <summary>
        /// Месец от датата на сменният график
        /// </summary>
        [Required]
        public string Month { get; set; } = null!;

        /// <summary>
        /// Година от датата на сменният график
        /// </summary>
        [Required]
        public int Year { get; set; }

        /// <summary>
        /// Списък със сменният график на потребителя
        /// </summary>
        [Required]
        public IList<ShiftsViewModel> UserShifts { get; set; }

        /// <summary>
        /// Колекция със идентификаторите и имената на смените
        /// </summary>
        [Required]
        public IList<KeyValuePairViewModel> ShiftsNames { get; set; }
    }
}
