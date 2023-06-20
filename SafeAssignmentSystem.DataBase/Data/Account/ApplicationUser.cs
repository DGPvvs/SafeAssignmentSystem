namespace SafeAssignmentSystem.DataBase.Data.Account
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.DataBase.Data.StaffsModels;
    using System.ComponentModel.DataAnnotations;
    using static SafeAssignmentSystem.Common.ModelsConstants.DataModelsConstants.ApplicationUserConstants;

    /// <summary>
    /// Модел на потребителите
    /// </summary>
    [Comment("Модел на потребителите")]
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.ChangedsSchedules = new HashSet<ChangedSchedule>();
        }

        /// <summary>
        /// Собствено име на потребител
        /// </summary>
        [Comment("Собствено име на потребител")]
        [Required]
        [StringLength(FirstName_Max_Length)]
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Фамилно име на потребител
        /// </summary>
        [Comment("Фамилно име на потребител")]
        [Required]
        [StringLength(LastName_Max_Length)]
        public string LastName { get; set; } = null!;

        /// <summary>
        /// Табелен номер на потребителя
        /// </summary>
        [Comment("Табелен номер на потребителя")]
        [Required]
        public int UserWorkNumber { get; set; }

        /// <summary>
        /// Колекция от записи сочещи към свързваща таблица с потребители
        /// </summary>
        [Comment("Колекция от записи сочещи към свързваща таблица с потребители")]
        public virtual ICollection<ApplicationUserPlantInstalation> ApplicationUserPlantInstalations { get; set; } = null!;

        /// <summary>
        /// Колекция от полета сочещи сменният график на потребителя
        /// </summary>
        [Comment("Колекция от полета сочещи сменният график на потребителя")]
        [Required]
        public virtual ICollection<ChangedSchedule> ChangedsSchedules { get; set; }
    }
}
