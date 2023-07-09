namespace SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels
{
    using System;

    public class ShiftTransferModel
    {
        public string ShiftName { get; set; } = null!;

        public TimeOnly Start { get; set; }

        public TimeOnly End { get; set; }
    }
}
