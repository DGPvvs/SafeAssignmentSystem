namespace SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels
{
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using System;
    using System.Collections.Generic;

    public class ComplexTransferModel
    {
        public ComplexTransferModel()
        {
            this.PlantInstalations = new HashSet<PlantInstalation>();
        }

        public Guid Id { get; set; }

        public string FullName { get; set; } = null!;

        public string Name { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public virtual ICollection<PlantInstalation> PlantInstalations { get; set; } = null!;
    }

}
