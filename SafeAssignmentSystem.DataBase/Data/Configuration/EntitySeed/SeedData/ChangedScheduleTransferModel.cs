namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData
{
    public class ChangedScheduleTransferModel
    {
        public ChangedScheduleTransferModel(int daysInMonth)
        {
            MonthlyDistribution = new string[daysInMonth];
        }

        public int UseNumber { get; set; }

        public string[] MonthlyDistribution { get; set; }
    }
}
