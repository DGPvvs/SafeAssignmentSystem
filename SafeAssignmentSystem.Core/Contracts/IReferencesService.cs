namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.Core.Models.TransferModels.ReferencesTransferModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IReferencesService
    {
        public Task<PositionInPlantTransferModel> GetTechnologicalPositionCondition(Guid plantId);
    }
}
