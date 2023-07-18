namespace SafeAssignmentSystem.Models.SafeAssignmentViewModels
{
    using SafeAssignmentSystem.Models.CommonViewModels;
    using System.ComponentModel.DataAnnotations;

    using static SafeAssignmentSystem.Common.ModelsConstants.DataModelsConstants.SafeAssignmentDocumentConstants;

    public class SafeAssignmentOrderingViewModel
    {
        public SafeAssignmentOrderingViewModel()
        {
            this.TechnologicalPositions = new List<KeyValuePairViewModel>();
        }

        /// <summary>
        /// Номер на наряд според вътрешнонарядната номерация
        /// </summary>
        [Required]
        [StringLength(Number_Max_Length, MinimumLength = Number_Min_Length, ErrorMessage = Error_Message_Number)]
        public string Number { get; set; } = null!;

        /// <summary>
        /// Идентификатор на технологична позиция
        /// </summary>
        [Required]
        public Guid TechnologicalPositionId { get; set; }

        /// <summary>
        /// Пълно име на инсталация
        /// </summary>
        [Required]
        public string PlantInstalationName { get; set; } = null!;

        /// <summary>
        /// Идентификатор на инсталация
        /// </summary>
        [Required]
        public Guid PlantInstalationId { get; set; }

        /// <summary>
        /// Колекция от технологичните позиции за инсталацията
        /// </summary>
        [Required]
        public ICollection<KeyValuePairViewModel> TechnologicalPositions { get; set; }
    }
}

