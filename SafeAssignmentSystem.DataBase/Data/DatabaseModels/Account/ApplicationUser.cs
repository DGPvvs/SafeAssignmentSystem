namespace SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.SafeAssignmentDocumentModels;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.StaffsModels;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static SafeAssignmentSystem.Common.ModelsConstants.DataModelsConstants.ApplicationUserConstants;

    /// <summary>
    /// Модел на потребителите
    /// </summary>
    [Comment("Модел на потребителите")]
    public class ApplicationUser : IdentityUser<Guid>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ApplicationUser()
        {
            // Инициализиране на колекция от записи сочещи към свързваща таблица с инсталации
            this.ApplicationUserPlantInstalations = new HashSet<ApplicationUserPlantInstalation>();

            // Инициализиране на колекция от полета сочещи сменният график на потребителя
            this.ChangedsSchedules = new HashSet<ChangedSchedule>();

            // Инициализиране на инверсно пропърти съдържако колекция от лицата (оператори или издаващи наряд) поискали откриване на нарядите
            this.PersonsRequestedsOpeningOrders = new HashSet<SafeAssignmentDocument>();

            // Инициализиране на инверсно пропърти съдържако колекция от лицата (дежурни електромонтьори) открили нарядите
            this.ЕlectriciansOpeningOrders = new HashSet<SafeAssignmentDocument>();

            // Инициализиране на инверсно пропърти съдържако колекция от лицата (дежурни електромонтьори) закрили нарядите
            this.ЕlectriciansClosingOrders = new HashSet<SafeAssignmentDocument>();

            // Инициализация на инверсно пропърти съдържако колекция от лицата от технологичния персонал, поискали подаване на напрежение
            this.PersonsRequestedsVoltageSupply = new HashSet<SafeAssignmentDocument>();

            // Инициализация на инверсно пропърти съдържако колекция от дежурни елмонтьори подали напрежение
            this.ElectriciansAppliedsVoltage = new HashSet<SafeAssignmentDocument>();
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
        /// Колекция от записи сочещи към свързваща таблица с инсталации
        /// </summary>
        [Comment("Колекция от записи сочещи към свързваща таблица с инсталации")]
        public virtual ICollection<ApplicationUserPlantInstalation> ApplicationUserPlantInstalations { get; set; } = null!;

        /// <summary>
        /// Колекция от полета сочещи сменният график на потребителя
        /// </summary>
        [Comment("Колекция от полета сочещи сменният график на потребителя")]
        [Required]
        public virtual ICollection<ChangedSchedule> ChangedsSchedules { get; set; }

        /// <summary>
        /// Инверсно пропърти съдържако колекция от лицата (оператори или издаващи наряд)
        /// поискали откриване на нарядите
        /// </summary>
        [Comment("Инверсно пропърти съдържако колекция от лицата (оператори или издаващи наряд) поискали откриване на нарядите")]
        [InverseProperty("PersonRequestedOpeningOrder")]
        public virtual ICollection<SafeAssignmentDocument> PersonsRequestedsOpeningOrders { get; set; }

        /// <summary>
        /// Инверсно пропърти съдържако колекция от лицата (дежурни електромонтьори)
        /// открили нарядите
        /// </summary>
        [Comment("Инверсно пропърти съдържако колекция от лицата (дежурни електромонтьори) открили нарядите")]
        [InverseProperty("ЕlectricianOpeningOrder")]
        public virtual ICollection<SafeAssignmentDocument> ЕlectriciansOpeningOrders { get; set; }

        /// <summary>
        /// Инверсно пропърти съдържако колекция от лицата (дежурни електромонтьори)
        /// закрили нарядите
        /// </summary>
        [Comment("Инверсно пропърти съдържако колекция от лицата (дежурни електромонтьори) закрили нарядите")]
        [InverseProperty("ЕlectricianClosingOrder")]
        public virtual ICollection<SafeAssignmentDocument> ЕlectriciansClosingOrders { get; set; }

        /// <summary>
        /// Инверсно пропърти съдържако колекция от лицата от технологичния персонал, поискали подаване на напрежение
        /// </summary>
        [Comment("Инверсно пропърти съдържако колекция от лицата от технологичния персонал, поискал подаване на напрежение")]
        [InverseProperty("PersonRequestedVoltageSupply")]
        public virtual ICollection<SafeAssignmentDocument> PersonsRequestedsVoltageSupply { get; set; }

        /// <summary>
        /// Инверсно пропърти съдържако колекция от дежурни елмонтьори подали напрежение
        /// </summary>
        [Comment("Инверсно пропърти съдържако колекция от дежурни елмонтьори подали напрежение")]
        [InverseProperty("ElectricianAppliedVoltage")]
        public virtual ICollection<SafeAssignmentDocument> ElectriciansAppliedsVoltage { get; set; }
    }
}
