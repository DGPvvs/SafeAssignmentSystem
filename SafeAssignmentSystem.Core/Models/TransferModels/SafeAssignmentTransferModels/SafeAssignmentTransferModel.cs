using SafeAssignmentSystem.Common.Enums;

namespace SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels
{
    using System;

    public class SafeAssignmentTransferModel
    {
        /// <summary>
        /// Идентификационен ключ
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Номер на наряд според вътрешнонарядната номерация
        /// </summary>
        public string Number { get; set; } = null!;

        /// <summary>
        /// Id на технологична позиция
        /// </summary>
        public Guid TechnologicalPositionId { get; set; }

        /// <summary>
        /// Дата на откриване на наряда
        /// </summary>
        public DateOnly OpeningDate { get; set; }

        /// <summary>
        /// Час на откриване на наряда
        /// </summary>
        public TimeOnly OpeningTime { get; set; }

        /// <summary>
        /// Id на потребител, поискал откриване на наряда
        /// </summary>
        public Guid PersonRequestedOpeningOrderId { get; set; }

        /// <summary>
        /// Id на потребител открил наряда
        /// </summary>
        public Guid? ЕlectricianOpeningOrderId { get; set; }

        /// <summary>
        /// Дата на закриване на наряда
        /// </summary>
        public DateOnly? ClosingDate { get; set; }

        /// <summary>
        /// Час на закриване на наряда
        /// </summary>
        public TimeOnly? ClosingTime { get; set; }

        /// <summary>
        /// Id на потребител закрил наряда
        /// </summary>
        public Guid? ЕlectricianClosingOrderId { get; set; }

        /// <summary>
        /// Id на потребител поискал подаване на напрежение
        /// </summary>
        public Guid? PersonRequestedVoltageSupplyId { get; set; }

        /// <summary>
        /// Id на потребител подал напрежение
        /// </summary>
        public Guid? ElectricianAppliedVoltageId { get; set; }

        /// <summary>
        /// Поле указващо статуса на наряда
        /// </summary>
        public StatusFlagsEnum Status { get; set; }
    }
}

