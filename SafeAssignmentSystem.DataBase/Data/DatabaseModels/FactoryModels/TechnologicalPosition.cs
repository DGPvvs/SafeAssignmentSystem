namespace SafeAssignmentSystem.DataBase.Data.FactoryModels
{
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.SafeAssignmentDocumentModels;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static SafeAssignmentSystem.Common.ModelsConstants.DataModelsConstants.TechnologicalPositionConstants;

    /// <summary>
    /// Модел на технологична позиция
    /// </summary>
    [Comment("Модел на технологична позиция")]
    public class TechnologicalPosition
    {
        public TechnologicalPosition()
        {
            this.Id = Guid.NewGuid();
            this.SafeAssignmentDocuments = new HashSet<SafeAssignmentDocument>();
        }

        /// <summary>
        /// Идентификационен ключ
        /// </summary>
        [Comment("Идентификационен ключ")]
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Наименование на технологичната позиция
        /// </summary>
        [Comment("Наименование на технологичната позиция")]
        [Required]
        [StringLength(Name_Max_Length)]
        public string Name { get; set; } = null!;

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
        public virtual PlantInstalation Instalation { get; set; } = null!;

        /// <summary>
        /// Колекция от наряди
        /// </summary>
        [Comment("Колекция от наряди")]
        public virtual ICollection<SafeAssignmentDocument> SafeAssignmentDocuments { get; set; } = null!;
    }
}
