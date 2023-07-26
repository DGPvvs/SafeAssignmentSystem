namespace SafeAssignmentSystem.Core.Models.TransferModels.ReferencesTransferModels
{
    using SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels;
    using System.Collections.Generic;

    /// <summary>
    /// Транспортен модел връщащ детайли за състоянието на всички технологични позиции в дадена инсталация
    /// </summary>
    public class PositionInPlantTransferModel
    {
        public PositionInPlantTransferModel()
        {
            this.Position = new List<SafeAssignmentTransferModel>();
            this.Positions = new List<PositionDetailsTransferModel>();
        }

        /// <summary>
        /// Пълно име на комплекса в който е технологичната позиция
        /// </summary>
        public string ComlpexFullName { get; set; } = null!;

        /// <summary>
        /// Пълно име на инсталация в която се намира технологичната позиция
        /// </summary>
        public string InstalationFullName { get; set; } = null!;

        /// <summary>
        /// Колекция от наряди към конкретна технологична позиция
        /// </summary>
        public ICollection<SafeAssignmentTransferModel> Position { get; set; }

        /// <summary>
        /// Колекция от технологични позиции с детайли за състоянието им 
        /// </summary>
        public ICollection<PositionDetailsTransferModel> Positions { get; set; }
    }
}
