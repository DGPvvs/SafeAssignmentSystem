namespace SafeAssignmentSystem.Models.WorkingRotationViewModels
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Модел на изгледа за смяна
    /// </summary>
    public class ShiftsViewModel
    {
        /// <summary>
        /// Конструктор на модела на изгледа за смяна
        /// </summary>
        public ShiftsViewModel()
        {
            this.ShiftId = Guid.Empty;
            this.ShiftName = string.Empty;
        }

        /// <summary>
        /// Дата на смяна
        /// </summary>
        [Required]
        public string Date { get; set; } = null!;

        /// <summary>
        /// Име на смяна
        /// </summary>
        public string ShiftName { get; set; }

        /// <summary>
        /// Идентификатор на смяна
        /// </summary>
        [Required]
        public Guid ShiftId { get; set; }
    }
}
