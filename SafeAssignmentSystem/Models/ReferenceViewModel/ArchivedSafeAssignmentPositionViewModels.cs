namespace SafeAssignmentSystem.Models.ReferenceViewModel
{
    /// <summary>
    /// Модел на изгледа за визуализиране на архивираните наряди
    /// </summary>
    public class ArchivedSafeAssignmentPositionViewModels
    {
        /// <summary>
        /// Номер на наряд според вътрешнонарядната номерация
        /// </summary>
        public string Number { get; set; } = null!;

        /// <summary>
        /// Дата на откриване на наряда
        /// </summary>
        public string OpeningDate { get; set; } = null!;

        /// <summary>
        /// Час на откриване на наряда
        /// </summary>
        public string OpeningTime { get; set; } = null!;

        /// <summary>
        /// Фамилия на потребител, поискал откриване на наряда
        /// </summary>
        public string PersonRequestedOpeningOrder { get; set; } = null!;

        /// <summary>
        /// Фамилия на потребител открил наряда
        /// </summary>
        public string ЕlectricianOpeningOrder { get; set; } = null!;

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
        public string PersonRequestedVoltageSupply { get; set; } = null!;

        /// <summary>
        /// Фамилия на потребител подал напрежение
        /// </summary>
        public string ElectricianAppliedVoltage { get; set; } = null!;
    }
}

