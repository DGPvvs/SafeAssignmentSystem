namespace SafeAssignmentSystem.Common.IO.Contracts
{
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;
    using SafeAssignmentSystem.Core.Models.TransferModels;
    using SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels;

    public interface IReader
    {
        public IEnumerable<ChangedScheduleTransferModel> ReadData(IFormFile file, IList<ChangedScheduleTransferModel> model);
    }
}
