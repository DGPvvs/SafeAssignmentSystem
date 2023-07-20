namespace SafeAssignmentSystem.Models.SafeAssignmentViewModels
{
    public class SafeAssignmentOpeningViewModel : SafeAssignmentOrderingViewModel
    {
        /// <summary>
        /// Фамилия на потребител, поискал откриване на наряда
        /// </summary>
        public string PersonRequestedOpeningOrder { get; set; } = null!;
    }
}

