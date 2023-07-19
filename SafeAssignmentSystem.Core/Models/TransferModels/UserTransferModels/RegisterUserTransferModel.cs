namespace SafeAssignmentSystem.Core.Models.TransferModels.UserTransferModels
{
    using System.Collections.Generic;

    public class RegisterUserTransferModel
    {
        public RegisterUserTransferModel()
        {
            this.Instalations = new List<Guid>();
        }

        /// <summary>
        /// Идентификатор на потребител
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Потребителско име
        /// </summary>
        public string UserName { get; set; } = null!;

        /// <summary>
        /// Собствено име на потребител
        /// </summary> 
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Фамилно име на потребител
        /// </summary>
        public string LastName { get; set; } = null!;

        /// <summary>
        /// Табелен номер на потребителя
        /// </summary>
        public int UserWorkNumber { get; set; }

        /// <summary>
        /// Нова парола
        /// </summary>
        public string Password { get; set; } = null!;

        /// <summary>
        /// Роля
        /// </summary>
        public string Role { get; set; } = null!;

        /// <summary>
        /// Списък с възможните инсталации
        /// </summary>
        public IList<Guid> Instalations { get; set; }
    }
}