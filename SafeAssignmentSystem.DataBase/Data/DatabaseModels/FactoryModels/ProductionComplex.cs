namespace SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static SafeAssignmentSystem.Common.ModelsConstants.DataModelsConstants.ProductionComplexConstants;

    /// <summary>
    /// Модел на производствените комплекси
    /// </summary>
    [Comment("Модел на производствените комплекси")]
    public class ProductionComplex
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ProductionComplex()
        {
            Id = Guid.NewGuid();
            PlantInstalations = new HashSet<PlantInstalation>();
        }

        /// <summary>
        /// Идентификационен ключ
        /// </summary>
        [Comment("Идентификационен ключ")]
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Пълно наименование на комплекса
        /// </summary>
        [Comment("Пълно наименование на комплекса")]
        [Required]
        [StringLength(FullName_Max_Length)]
        public string FullName { get; set; } = null!;

        /// <summary>
        /// Съкратено наименование на комплекса
        /// </summary>
        [Comment("Съкратено наименование на комплекса")]
        [Required]
        [StringLength(Name_Max_Length)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Указател, показващ дали модела на комплекса е изтрит
        /// </summary>
        [Comment("Указател, показващ дали модела на комплекса е изтрит")]
        [Required]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Колекция от технологични позиции
        /// </summary>
        [Comment("Колекция от технологични позиции")]
        public virtual ICollection<PlantInstalation> PlantInstalations { get; set; } = null!;
    }
}
