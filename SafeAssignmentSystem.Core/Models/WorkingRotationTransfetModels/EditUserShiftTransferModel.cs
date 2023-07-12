namespace SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels
{
    using System;

    public class EditUserShiftTransferModel : UserShiftTransferModel
    {        
        public Guid UserId { get; set; }

        public Guid ShiftId { get; set; }
    }
}
