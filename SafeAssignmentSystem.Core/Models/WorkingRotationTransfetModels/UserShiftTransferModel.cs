namespace SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels
{
    using System;

    /// <summary>
    /// Трансферен модел на смяна към потребител
    /// </summary>
    public class UserShiftTransferModel
    {
        /// <summary>
        /// Име на смяна
        /// </summary>
        public string ShiftName { get; set; } = null!;

        /// <summary>
        /// Начален час на смяна
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// Краен час на смяна
        /// </summary>
        public DateTime End { get; set; }

        /// <summary>
        /// Дата на смяната
        /// </summary>
        public DateTime Date { get; set; }
    }
}
