namespace SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels
{
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static SafeAssignmentSystem.Common.ModelsConstants.DataModelsConstants.PlantInstalationConstants;

    /// <summary>
    /// Модел на инсталациите
    /// </summary>
    [Comment("Модел на инсталациите")]
    public class PlantInstalation
    {
        public PlantInstalation()
        {
            Id = Guid.NewGuid();
            TechnologicalPositions = new HashSet<TechnologicalPosition>();
            ApplicationUserPlantInstalations = new HashSet<ApplicationUserPlantInstalation>();
        }

        /// <summary>
        /// Идентификационен ключ
        /// </summary>
        [Comment("Идентификационен ключ")]
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Пълно наименование на инсталацията
        /// </summary>
        [Comment("Пълно наименование на инсталацията")]
        [Required]
        [StringLength(FullName_Max_Length)]
        public string FullName { get; set; } = null!;

        /// <summary>
        /// Съкратено наименование на инсталацията
        /// </summary>
        [Comment("Съкратено наименование на инсталацията")]
        [Required]
        [StringLength(Name_Max_Length)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Id на комплекс
        /// </summary>
        [Comment("Id на комплекс")]
        [Required]
        [ForeignKey(nameof(Complex))]
        public Guid ComplexId { get; set; }

        /// <summary>
        /// Кореспондиращо поле съдържащо комплекса
        /// </summary>
        [Comment("Кореспондиращо поле съдържащо комплекса")]
        [Required]
        public virtual ProductionComplex Complex { get; set; } = null!;

        /// <summary>
        /// Колекция от технологични позиции
        /// </summary>
        [Comment("Колекция от технологични позиции")]
        public virtual ICollection<TechnologicalPosition> TechnologicalPositions { get; set; }

        /// <summary>
        /// Колекция от записи сочещи към свързваща таблица с потребители
        /// </summary>
        [Comment("Колекция от записи сочещи към свързваща таблица с потребители")]
        public virtual ICollection<ApplicationUserPlantInstalation> ApplicationUserPlantInstalations { get; set; } = null!;
    }
}
