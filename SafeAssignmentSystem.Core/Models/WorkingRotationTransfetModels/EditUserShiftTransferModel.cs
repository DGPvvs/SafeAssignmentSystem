namespace SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels
{
    using System;

    /// <summary>
    /// Трансферен модел за редакция на сменен график
    /// </summary>
    public class EditUserShiftTransferModel : UserShiftTransferModel
    {        
        /// <summary>
        /// Идентификатор на потребител
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Идентификатор на смяна
        /// </summary>
        public Guid ShiftId { get; set; }
    }
}
