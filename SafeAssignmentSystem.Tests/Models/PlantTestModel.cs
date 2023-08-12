namespace SafeAssignmentSystem.Tests.Models
{
    using System;

    public class PlantTestModel
    {
        public PlantTestModel(Guid plantId)
        {
            this.PlantId = plantId;
            this.CountRequestedVoltageSupply = 0;
            this.CountRequested = 0;
            this.CountOpening = 0;
            this.CountClosing = 0;
            this.CountArchive = 0;
        }

        public Guid PlantId { get; set; }

        public int CountRequested { get; set; }

        public int CountOpening { get; set; }

        public int CountClosing { get; set; }

        public int CountRequestedVoltageSupply { get; set; }

        public int CountArchive { get; set; }
    }
}
