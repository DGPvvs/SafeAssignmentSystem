namespace SafeAssignmentSystem.Common.IO.Contracts
{
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;
    using SafeAssignmentSystem.Core.Models.TransferModels;

    internal interface IReader
    {
        public IEnumerable<ChangedScheduleTransferModel> Reader(IFormFile file);
    }
}
