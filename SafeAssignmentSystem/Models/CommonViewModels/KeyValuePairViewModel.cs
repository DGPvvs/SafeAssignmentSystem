namespace SafeAssignmentSystem.Models.CommonViewModels
{
    /// <summary>
    /// Модел на изглед съдържащ двойки ключ-стойност във формат Guid-string
    /// </summary>
    public class KeyValuePairViewModel
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public KeyValuePairViewModel(Guid id, string value)
        {
            this.KvP = new KeyValuePair<Guid, string>(id, value);
        }

        /// <summary>
        /// Двойка ключ-стойност
        /// </summary>
        public KeyValuePair<Guid, string> KvP { get; set; }
    }
}
