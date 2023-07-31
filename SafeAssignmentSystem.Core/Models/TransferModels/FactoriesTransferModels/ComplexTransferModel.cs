namespace SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels
{
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Трансферен модел на комплекс
    /// </summary>
    public class ComplexTransferModel
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ComplexTransferModel()
        {
            this.PlantInstalations = new HashSet<PlantInstalation>();
        }

        /// <summary>
        /// Идентификатор на комплекс
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Пълно име на комплекс
        /// </summary>
        public string FullName { get; set; } = null!;

        /// <summary>
        /// Кратко име на комплекс
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Поле указващо дали комплекса е изтрит
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Колекция от свързани с комплекса инсталации
        /// </summary>
        public virtual ICollection<PlantInstalation> PlantInstalations { get; set; } = null!;
    }

}
