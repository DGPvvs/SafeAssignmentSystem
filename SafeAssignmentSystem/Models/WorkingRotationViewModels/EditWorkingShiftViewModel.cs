namespace SafeAssignmentSystem.Models.WorkingRotationViewModels
{
    /// <summary>
    /// Модел на изгледа за редакция на смяна
    /// </summary>
    public class EditWorkingShiftViewModel : WorkingShiftViewModel
    {
        /// <summary>
        /// Идентификатор на смяната
        /// </summary>
        public Guid Id { get; set; }
    }
}
