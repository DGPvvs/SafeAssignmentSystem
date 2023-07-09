namespace SafeAssignmentSystem.Core.Service
{
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Common.Exeptions;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Data;
    using SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels;
    using SafeAssignmentSystem.DataBase.Data.Common;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.StaffsModels;
    using System;
    using System.Threading.Tasks;

    public class WorkingRotationService : IWorkingRotationService
    {
        private readonly SafeAssignmentDbContext context;
        private readonly IRepository repo;

        public WorkingRotationService(
            SafeAssignmentDbContext context,
            IRepository repo)
        {
            this.context = context;
            this.repo = repo;
        }

        public async Task AddShiftAsync(ShiftTransferModel transfer)
        {
            var duplicate = await this.repo
                .AllReadonly<WorkingShift>(sh => sh.ShiftName == transfer.ShiftName)
                .FirstOrDefaultAsync();

            if (!(duplicate is null))
            {
                throw new IdentityЕxception();
            }

            var startTime = new DateTime(1, 1, 1) + transfer.Start.ToTimeSpan();
            var endTime = new DateTime(1, 1, 1) + transfer.End.ToTimeSpan();

            if (transfer.Start > transfer.End)
            {                
                endTime = new DateTime(1, 1, 2) + transfer.End.ToTimeSpan();
            }

            var entity = new WorkingShift()
            {
                ShiftName = transfer.ShiftName,
                StartTime = startTime,
                EndTime = endTime
            };

            await this.repo.AddAsync(entity);
            await this.repo.SaveChangesAsync();
        }
    }
}
