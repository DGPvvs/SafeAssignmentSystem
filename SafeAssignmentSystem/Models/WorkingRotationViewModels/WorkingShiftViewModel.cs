using System.ComponentModel.DataAnnotations;

using static SafeAssignmentSystem.Common.ModelsConstants.DataModelsConstants.WorkingShiftConstants;

namespace SafeAssignmentSystem.Models.WorkingRotationViewModels

{
    /// <summary>
    /// Модел съдържащ данните в изображението за създаване на смени
    /// </summary>
    public class WorkingShiftViewModel
    {
        /// <summary>
        /// Конструктор задаващ първоначални стойности на полетата StartTime и EndTime  
        /// </summary>
        public WorkingShiftViewModel()
        {
            this.StartTime = "00:00";
            this.EndTime = "00:00";
        }

        /// <summary>
        /// Име на смяната
        /// </summary>
        [Required]
        [StringLength(ShiftName_Max_Length, MinimumLength = ShiftName_Min_Length)]
        public string ShiftName { get; set; } = null!;

        /// <summary>
        /// Начален час на смяната
        /// </summary>
        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public string StartTime { get; set; } = null!;

        /// <summary>
        /// Краен час на смяната
        /// </summary>
        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public string EndTime { get; set; } = null!;
    }
}