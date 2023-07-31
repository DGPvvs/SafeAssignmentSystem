namespace SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels
{
    using System;

    /// <summary>
    /// Трансферен модел на сменен график
    /// </summary>
    public class ShiftsTransferModel
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ShiftsTransferModel()
        {
            this.ShiftId = Guid.Empty;
            this.ShiftName = string.Empty;
        }

        /// <summary>
        /// Дата 
        /// </summary>
        public DateOnly Date { get; set; }

        /// <summary>
        /// Име на смяна
        /// </summary>
        public string ShiftName { get; set; }

        /// <summary>
        /// Идентификатор на смяна
        /// </summary>
        public Guid ShiftId { get; set; }
    }
}
