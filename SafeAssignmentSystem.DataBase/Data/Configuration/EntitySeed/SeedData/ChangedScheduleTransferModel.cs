namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData
{
    /// <summary>
    /// Трансферен модел за зареждане на смените при четене от файл
    /// </summary>
    public class ChangedScheduleTransferModel
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="daysInMonth"></param>
        public ChangedScheduleTransferModel(int daysInMonth)
        {
            MonthlyDistribution = new string[daysInMonth];
        }

        /// <summary>
        /// Табелен номер
        /// </summary>
        public int UseNumber { get; set; }

        /// <summary>
        /// Месечно разпределение на смените
        /// </summary>
        public string[] MonthlyDistribution { get; set; }
    }
}
