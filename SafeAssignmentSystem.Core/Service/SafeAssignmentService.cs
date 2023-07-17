namespace SafeAssignmentSystem.Core.Service
{
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels;
    using SafeAssignmentSystem.DataBase.Data.Common;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.SafeAssignmentDocumentModels;
    using System;
    using System.Threading.Tasks;

    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;



    public class SafeAssignmentService : ISafeAssignmentService
    {
        private readonly IRepository repo;

        public SafeAssignmentService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task<StatusModel> CreateSafeAssignment(SafeAssignmentTransferModel transfer)
        {
            StatusModel result = new StatusModel()
            {
                Success = false
            };

            var entity = new SafeAssignmentDocument()
            {
                Number = transfer.Number,
                TechnologicalPositionId = transfer.TechnologicalPositionId,
                PersonRequestedOpeningOrderId = transfer.PersonRequestedOpeningOrderId,
                Status = transfer.Status
            };

            try
            {
                await this.repo.AddAsync(entity);
                await this.repo.SaveChangesAsync();

                result.Success = true;
                result.Description = Create_SafeAssignment_Document_Success;
            }
            catch (Exception)
            {
                result.Description = Create_SafeAssignment_Document_Fail;                
            }

            return result;
        }
    }
}
