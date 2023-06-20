namespace SafeAssignmentSystem.DataBase.Data.FactoryModels
{
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.DataBase.Data.Account;
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
        public ProductionComplex()
        {
            this.Id = Guid.NewGuid();
            this.PlantInstalations = new HashSet<PlantInstalation>();
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
        /// Колекция от технологични позиции
        /// </summary>
        [Comment("Колекция от технологични позиции")]
        public virtual ICollection<PlantInstalation> PlantInstalations { get; set; } = null!;
    }
}
