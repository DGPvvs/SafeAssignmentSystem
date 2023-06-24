namespace SafeAssignmentSystem.Core.Models.TransferModels
{
    public class ChangedScheduleTransferModel
    {
        public ChangedScheduleTransferModel(int daysInMonth)
        {
            this.MonthlyDistribution = new string[daysInMonth];
        }

        public int UseNumber { get; set; }

        public string[] MonthlyDistribution { get; set; }
    }
}
