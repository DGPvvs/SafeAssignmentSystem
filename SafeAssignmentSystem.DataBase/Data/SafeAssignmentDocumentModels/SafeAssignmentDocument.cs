namespace SafeAssignmentSystem.DataBase.Data.SafeAssignmentDocumentModels
{
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.DataBase.Data.Account;
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    using static SafeAssignmentSystem.Common.ModelsConstants.DataModelsConstants.SafeAssignmentDocumentConstants;

    /// <summary>
    /// Модел на нарядите
    /// </summary>
    [Comment("Модел на нарядите")]
    public class SafeAssignmentDocument
    {
        public SafeAssignmentDocument()
        {
            this.Id = Guid.NewGuid();
        }

        /// <summary>
		/// Идентификационен ключ
		/// </summary>
		[Comment("Идентификационен ключ")]
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Номер на наряд според вътрешнонарядната номерация
        /// </summary>
        [Comment("Номер на наряд според вътрешнонарядната номерация")]
        [Required]
        [StringLength(Number_Max_Length)]
        public string Number { get; set; } = null!;

        /// <summary>
        /// Id на технологична позиция
        /// </summary>
        [Comment("Id на технологична позиция")]
        [Required]
        public Guid TechnologicalPositionId { get; set; }

        /// <summary>
        /// Кореспондиращо поле на технологична позиция
        /// </summary>
        [Comment("Кореспондиращо поле на технологична позиция")]
        [Required]
        public virtual TechnologicalPosition TechnologicalPosition { get; set; } = null!;

        /// <summary>
        /// Състояние на наряда
        /// true – наряда е открит
        /// false – наряда не е открит или е закрит
        /// </summary>
        [Comment("Състояние на наряда")]
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Дата и час на откриване на наряда
        /// </summary>
        [Comment("Дата и час на откриване на наряда")]
        [Required]
        public DateTime OpeningDate { get; set; }

        /// <summary>
        /// Id на потребител, поискал откриване на наряда
        /// </summary>
        [Comment("Id на потребител, поискал откриване на наряда")]
        [ForeignKey(nameof(PersonRequestedOpeningOrder))]
        [Required]
        public string PersonRequestedOpeningOrderId { get; set; } = null!;

        /// <summary>
        /// Кореспондиращо поле на потребителя, поискал откриването на наряда
        /// </summary>
        [Comment("Кореспондиращо поле на потребителя, поискал откриването на наряда")]
        [Required]
        public virtual ApplicationUser PersonRequestedOpeningOrder { get; set; } = null!;

        /// <summary>
        /// Id на потребител открил наряда
        /// </summary>
        [Comment("Id на потребител открил наряда")]
        [ForeignKey(nameof(ЕlectricianOpeningOrder))]
        public string? ЕlectricianOpeningOrderId { get; set; }

        /// <summary>
        /// Кореспондиращо поле на потребител открил наряда
        /// </summary>
        [Comment("Кореспондиращо поле на потребител открил наряда")]
        public virtual ApplicationUser? ЕlectricianOpeningOrder { get; set; }

        /// <summary>
        /// Дата и час на закриване на наряда
        /// </summary>
        [Comment("Дата и час на закриване на наряда")]
        public DateTime? ClosingDate { get; set; }

        /// <summary>
        /// Id на потребител закрил наряда
        /// </summary>
        [Comment("Id на потребител закрил наряда")]
        [ForeignKey(nameof(ЕlectricianClosingOrder))]
        public string? ЕlectricianClosingOrderId { get; set; }

        /// <summary>
        /// Кореспондиращо поле на потребител закрил наряда
        /// </summary>
        [Comment("Кореспондиращо поле на потребител закрил наряда")]
        public virtual ApplicationUser? ЕlectricianClosingOrder { get; set; }

        /// <summary>
        /// Id на потребител поискал подаване на напрежение
        /// </summary>
        [Comment("Id на потребител поискал подаване на напрежение")]
        [ForeignKey(nameof(PersonRequestedVoltageSupply))]
        public string? PersonRequestedVoltageSupplyId { get; set; }

        /// <summary>
        /// Кореспондиращо поле на потребител поискал подаване на напрежение
        /// </summary>
        [Comment("Кореспондиращо поле на потребител поискал подаване на напрежение")]
        public virtual ApplicationUser? PersonRequestedVoltageSupply { get; set; }

        /// <summary>
        /// Id на потребител подал напрежение
        /// </summary>
        [Comment("Id на потребител подал напрежение")]
        [ForeignKey(nameof(ElectricianAppliedVoltage))]
        public string? ElectricianAppliedVoltageId { get; set; }

        /// <summary>
        /// Кореспондиращо поле на потребител подал напрежение
        /// </summary>
        [Comment("Кореспондиращо поле на потребител подал напрежение")]
        public virtual ApplicationUser? ElectricianAppliedVoltage { get; set; }

        /// <summary>
        /// Състояние на технологичната позиция
        /// true – подадено напрежение
        /// false – свалено напрежение
        /// </summary>
        [Comment("Състояние на технологичната позиция")]
        [Required]
        public bool IsAppliedVoltage { get; set; }
    }
}
