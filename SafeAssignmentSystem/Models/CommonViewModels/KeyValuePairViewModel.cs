namespace SafeAssignmentSystem.Models.CommonViewModels
{
    public class KeyValuePairViewModel
    {
        public KeyValuePairViewModel(Guid id, string value)
        {
            this.KvP = new KeyValuePair<Guid, string>(id, value);
        }

        public KeyValuePair<Guid, string> KvP { get; set; }
    }
}
