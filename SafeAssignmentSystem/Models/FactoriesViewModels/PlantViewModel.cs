namespace SafeAssignmentSystem.Models.FactoriesViewModels
{
    using System.ComponentModel.DataAnnotations;
    using SafeAssignmentSystem.Models.CommonViewModels;
    using static SafeAssignmentSystem.Common.ModelsConstants.DataModelsConstants.PlantInstalationConstants;

    public class PlantViewModel
    {
        public PlantViewModel()
        {
            this.Complexes = new List<KeyValuePairViewModel>();
        }

        /// <summary>
        /// Пълно наименование на инсталацията
        /// </summary>
        [Required]
        [StringLength(FullName_Max_Length, MinimumLength = FullName_Min_Length, ErrorMessage = Error_Message_Name)]
        public string FullName { get; set; } = null!;

        /// <summary>
        /// Съкратено наименование на инсталацията
        /// </summary>        
        [Required]
        [StringLength(Name_Max_Length, MinimumLength = Name_Min_Length, ErrorMessage = Error_Message_Name)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Id на комплекс
        /// </summary>
        [Required]        
        public Guid ComplexId { get; set; }

        /// <summary>
        /// Колекция от модели на комплекси
        /// </summary>        
        //[Required]
        public IEnumerable<KeyValuePairViewModel> Complexes { get; set; } = null!;
    }
}
