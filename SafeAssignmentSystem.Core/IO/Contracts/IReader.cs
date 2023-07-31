namespace SafeAssignmentSystem.Common.IO.Contracts
{
    using Microsoft.AspNetCore.Http;
    using SafeAssignmentSystem.Core.Models.TransferModels;
    using System.Collections.Generic;

    /// <summary>
    /// Интерфейс деклариращ методи за четене на сменен график
    /// </summary>
    public interface IReader
    {
        /// <summary>
        /// Дефиниция на метод за четене на сменен график от файлов стриим
        /// </summary>
        /// <param name="file"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public IEnumerable<ChangedScheduleTransferModel> ReadData(IFormFile file, IList<ChangedScheduleTransferModel> model);
    }
}
