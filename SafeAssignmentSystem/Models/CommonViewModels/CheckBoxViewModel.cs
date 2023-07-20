namespace SafeAssignmentSystem.Models.CommonViewModels
{
    /// <summary>
    /// Модел за визуализация на елементи от тип CheckedBox
    /// </summary>
    public class CheckBoxViewModel
    {
        /// <summary>
        /// Идентификатор на елемента
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Кратко име на елемента
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Пълно име на елемента
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// Указател показващ дали елемента е избран
        /// </summary>
        public bool Selected { get; set; } 
    }
}