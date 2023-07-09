using System.ComponentModel.DataAnnotations;

using static SafeAssignmentSystem.Common.ModelsConstants.DataModelsConstants.WorkingShiftConstants;

namespace SafeAssignmentSystem.Models.WorkingRotationViewModels

{
    public class WorkingShiftViewModel
    {
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
        public TimeOnly StartTime { get; set; }

        /// <summary>
        /// Краен час на смяната
        /// </summary>
        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public TimeOnly EndTime { get; set; }
    }
}