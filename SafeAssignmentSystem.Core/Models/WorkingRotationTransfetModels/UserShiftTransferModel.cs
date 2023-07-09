namespace SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels
{
    using System;

    public class UserShiftTransferModel
    {
        public string ShiftName { get; set; } = null!;

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public DateTime Date { get; set; }
    }
}
