namespace SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels
{
    using System;

    public class TechnologicalPositionTransferModel
    {
        /// <summary>
        /// Идентификационен ключ
        /// </summary>
        public Guid Id { get; set; }        

        /// <summary>
        /// Наименование на технологичната позиция
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Id на инсталация
        /// </summary>
        public Guid InstalationId { get; set; }

        /// <summary>
        /// Кратко наименование на инсталация
        /// </summary>
        public string InstalationName { get; set; } = null!;

        /// <summary>
        /// Комплекс към който се числи инсталацията
        /// </summary>
        public string ComplexName { get; set; } = null!;
    }
}
