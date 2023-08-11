namespace SafeAssignmentSystem.Tests.Models
{
    using System;

    public class PlantTestModel
    {
        public Guid PlantId { get; set; }

        public int CountSafeAssignments { get; set; }

        public int CountUnderRepair { get; set; }

        public int CountNoVoltageApplied { get; set; }
    }
}
