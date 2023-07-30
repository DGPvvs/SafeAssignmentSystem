namespace SafeAssignmentSystem.Models.SafeAssignmentViewModels
{
    /// <summary>
    /// Модел на изгледа за архивираните наряди
    /// </summary>
    public class SafeAssignmentArchivedViewModel : SafeAssignmentClosingViewModel
    {
        /// <summary>
        /// Дата на закриване на наряда
        /// </summary>
        public string ClosingDate { get; set; } = null!;

        /// <summary>
        /// Час на закриване на наряда
        /// </summary>
        public string ClosingTime { get; set; } = null!;

        /// <summary>
        /// Фамилия на потребител закрил наряда
        /// </summary>
        public string ЕlectricianClosingOrder { get; set; } = null!;

        /// <summary>
        /// Фамилия на потребител поискал подаване на напрежение
        /// </summary>
        public string MyProPersonRequestedVoltageSupplyperty { get; set; } = null!;

        /// <summary>
        /// Фамилия на потребител подал напрежение
        /// </summary>
        public string ElectricianAppliedVoltage { get; set; } = null!;
    }
}