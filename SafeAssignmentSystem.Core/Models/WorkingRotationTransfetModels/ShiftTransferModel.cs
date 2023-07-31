namespace SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels
{
    using System;

    /// <summary>
    /// Трансферен модел на смяна
    /// </summary>
    public class ShiftTransferModel
    {
        /// <summary>
        /// Идентификатор на смяна
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Име на смяна
        /// </summary>
        public string ShiftName { get; set; } = null!;

        /// <summary>
        /// Начален час на смяна
        /// </summary>
        public TimeOnly Start { get; set; }

        /// <summary>
        /// Краен час на смяна
        /// </summary>
        public TimeOnly End { get; set; }
    }
}
