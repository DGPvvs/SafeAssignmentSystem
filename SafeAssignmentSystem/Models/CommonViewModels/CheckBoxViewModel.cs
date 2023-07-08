namespace SafeAssignmentSystem.Models.CommonViewModels
{
    public class CheckBoxViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Selected { get; set; } 
    }
}