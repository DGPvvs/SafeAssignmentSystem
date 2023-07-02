namespace SafeAssignmentSystem.Models.FactoriesViewModels
{
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using System.ComponentModel.DataAnnotations;

    using static SafeAssignmentSystem.Common.ModelsConstants.DataModelsConstants.ProductionComplexConstants;

    public class ComplexViewModel
    {
        /// <summary>
        /// Пълно наименование на комплекса
        /// </summary>
        [Required]
        [StringLength(FullName_Max_Length, MinimumLength = FullName_Min_Length, ErrorMessage = Error_Message_Name)]
        public string FullName { get; set; } = null!;

        /// <summary>
        /// Съкратено наименование на комплекса
        /// </summary>    
        [Required]
        [StringLength(Name_Max_Length, MinimumLength = Name_Min_Length, ErrorMessage = Error_Message_Name)]
        public string Name { get; set; } = null!;
    }    
}
