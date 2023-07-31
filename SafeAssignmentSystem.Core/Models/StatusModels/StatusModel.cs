namespace SafeAssignmentSystem.Core.Models.StatusModels
{
    /// <summary>
    /// Статус модел
    /// </summary>
    public class StatusModel
    {
        /// <summary>
        /// Стойност на статус модела - true успешна операцияр false неуспешна операция
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Описание на резултата
        /// </summary>
        public string Description { get; set; } = null!;
    }
}
