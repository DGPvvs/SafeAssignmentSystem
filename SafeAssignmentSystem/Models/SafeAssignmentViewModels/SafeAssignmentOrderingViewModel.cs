namespace SafeAssignmentSystem.Models.SafeAssignmentViewModels
{
    using SafeAssignmentSystem.Models.CommonViewModels;
    using System.ComponentModel.DataAnnotations;

    using static SafeAssignmentSystem.Common.ModelsConstants.DataModelsConstants.SafeAssignmentDocumentConstants;

	/// <summary>
	/// Mодел на изображение при регистрация на наряд
	/// </summary>
	public class SafeAssignmentOrderingViewModel
    {
        /// <summary>
        /// Конструктор на модела на изображение при регистрация на наряд
        /// </summary>
        public SafeAssignmentOrderingViewModel()
        {
            this.TechnologicalPositions = new List<KeyValuePairViewModel>();
        }

        /// <summary>
        /// Номер на наряд според вътрешнонарядната номерация
        /// </summary>
        [Required]
        [RegularExpression(Number_Regex_Pattern, ErrorMessage = Error_Message)]
        public string Number { get; set; } = null!;

        /// <summary>
        /// Идентификатор на технологична позиция
        /// </summary>
        [Required]
        public Guid TechnologicalPositionId { get; set; }

        /// <summary>
        /// Пълно име на инсталация
        /// </summary>
        public string FullPlantInstalationName { get; set; } = null!;

        /// <summary>
        /// Кратко име на инсталация
        /// </summary>
        [Required]
        public string PlantInstalationName { get; set; } = null!;

		/// <summary>
		/// Идентификатор на инсталация
		/// </summary>
		[Required]
        public Guid PlantInstalationId { get; set; }

        /// <summary>
        /// Кратко име на комплекс
        /// </summary>
        [Required]
        public string ComplexName { get; set; } = null!;

        /// <summary>
        /// Пълно име на комплекс
        /// </summary>
        public string FullComplexName { get; set; } = null!;

        /// <summary>
        /// Колекция от технологичните позиции за инсталацията
        /// </summary>
        [Required]
        public ICollection<KeyValuePairViewModel> TechnologicalPositions { get; set; }
    }
}

