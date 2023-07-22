namespace SafeAssignmentSystem.Models.FactoriesViewModels
{
    using SafeAssignmentSystem.Models.CommonViewModels;
    using System.ComponentModel.DataAnnotations;
    using static SafeAssignmentSystem.Common.ModelsConstants.DataModelsConstants.TechnologicalPositionConstants;

    /// <summary>
    /// Модел на изображение описващ технологична позиция при създаването на и 
    /// </summary>
    public class TechnologicalPositionViewModel
    {
        /// <summary>
        /// Конструктор инициализиращ модела на изображение на технологичната позиция
        /// </summary>
        public TechnologicalPositionViewModel()
        {
            this.Instalations = new List<KeyValuePairViewModel>();
        }

        /// <summary>
        /// Наименование на технологичната позиция
        /// </summary>
        [Required]
        [StringLength(Name_Max_Length, MinimumLength = Name_Min_Length, ErrorMessage = Error_Message_Name)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Id на инсталация
        /// </summary>
        [Required]
        public Guid InstalationId { get; set; }

        /// <summary>
        /// Колекция от ключ - име на инсталации
        /// </summary>        
        //[Required]
        public IEnumerable<KeyValuePairViewModel> Instalations { get; set; } = null!;        
    }
}
