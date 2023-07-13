namespace SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels
{
    using System;

    public class ShiftsTransferModel
    {
        public ShiftsTransferModel()
        {
            this.ShiftId = Guid.Empty;
            this.ShiftName = string.Empty;
        }

        public DateOnly Date { get; set; }

        public string ShiftName { get; set; }

        public Guid ShiftId { get; set; }
    }
}
