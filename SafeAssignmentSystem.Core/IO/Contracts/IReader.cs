namespace SafeAssignmentSystem.Common.IO.Contracts
{
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;
    using SafeAssignmentSystem.Core.Models.TransferModels;

    public interface IReader
    {
        public IEnumerable<ChangedScheduleTransferModel> ReadData(IFormFile file, IList<ChangedScheduleTransferModel> model);
    }
}
