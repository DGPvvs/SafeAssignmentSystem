﻿namespace SafeAssignmentSystem.Models.SafeAssignmentViewModels
{
    public class SafeAssignmentClosingViewModel : SafeAssignmentOpeningViewModel
    {
        /// <summary>
        /// Фамилия на потребител открил наряда
        /// </summary>
        public string ЕlectricianOpeningOrder { get; set; } = null!;

        /// <summary>
        /// Дата на откриване на наряда
        /// </summary>
        public string OpeningDate { get; set; } = null!;

        /// <summary>
        /// Час на откриване на наряда
        /// </summary>
        public string OpeningTime { get; set; } = null!;
    }
}
