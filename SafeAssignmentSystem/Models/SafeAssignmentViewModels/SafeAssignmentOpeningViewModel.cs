namespace SafeAssignmentSystem.Models.SafeAssignmentViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class SafeAssignmentOpeningViewModel : SafeAssignmentOrderingViewModel
    {
        /// <summary>
        /// Идентификатор на наряд
        /// </summary>
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Фамилия на потребител, поискал откриване на наряда
        /// </summary>
        [Required]
        public string PersonRequestedOpeningOrder { get; set; } = null!;

        /// <summary>
        /// Име на технологичната позиция
        /// </summary>
        [Required]
        public string TechnologicalPositionName { get; set; } = null!;        
    }
}

