namespace SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels
{
    using System;

    public class PlantTransferModel
    {
        /// <summary>
        /// Идентификационен ключ
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Пълно наименование на инсталацията
        /// </summary>        
        public string FullName { get; set; } = null!;

        /// <summary>
        /// Съкратено наименование на инсталацията
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Id на комплекс
        /// </summary>
        public Guid ComplexId { get; set; }

        /// <summary>
        /// Кратко наименование на комплекс
        /// </summary>
        public string ComplexName { get; set; } = null!;
    }
}
