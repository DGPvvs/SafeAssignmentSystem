namespace SafeAssignmentSystem.DataBase.Data.Account
{
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Свързваща таблица между потребителите и инсталациите
    /// </summary>
    [Comment("Свързваща таблица между потребителите и инсталациите")]
    public class ApplicationUserPlantInstalation
    {
        /// <summary>
        /// Id на потребител
        /// </summary>
        [Comment("Id на потребител")]
        [Required]
        [ForeignKey(nameof(ApplicationUser))]
        public string UserId { get; set; } = null!;

        /// <summary>
        /// Кореспондиращо поле съдържащо потребител
        /// </summary>
        [Comment("Кореспондиращо поле съдържащо потребител")]
        [Required]
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        /// <summary>
        /// Id на инсталация
        /// </summary>
        [Comment("Id на инсталация")]
        [Required]
        [ForeignKey(nameof(Instalation))]
        public Guid InstalationId { get; set; }

        /// <summary>
        /// Кореспондиращо поле съдържащо инсталацията
        /// </summary>
        [Comment("Кореспондиращо поле съдържащо инсталацията")]
        [Required]
        public virtual PlantInstalation Instalation { get; set; } = null!;
    }
}
