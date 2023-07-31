namespace SafeAssignmentSystem.Core.Models.TransferModels
{
    /// <summary>
    /// Трансферен модел на сменният график
    /// </summary>
    public class ChangedScheduleTransferModel
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="daysInMonth"></param>
        public ChangedScheduleTransferModel(int daysInMonth)
        {
            this.MonthlyDistribution = new string[daysInMonth];
        }

        /// <summary>
        /// Табелен номер на потребител
        /// </summary>
        public int UseNumber { get; set; }

        /// <summary>
        /// Година и месец за който се отнася сменният график
        /// </summary>
        public DateOnly Date { get; set; }

        /// <summary>
        /// Разпределение на смените на потребителя по дати от месеца
        /// </summary>
        public string[] MonthlyDistribution { get; set; }
    }
}
