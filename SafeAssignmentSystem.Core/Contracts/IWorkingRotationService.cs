namespace SafeAssignmentSystem.Core.Contracts
{
    using Microsoft.AspNetCore.Http;
    using SafeAssignmentSystem.Common.Overrides;
	using SafeAssignmentSystem.Core.Models.StatusModels;
	using SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels;
    using System;
	using System.Collections.Generic;
	using System.Threading.Tasks;

    public interface IWorkingRotationService
    {
        public Task AddShiftAsync(ShiftTransferModel transfer);
        public Task EditShiftAsync(ShiftTransferModel transfer);
        public Task<IEnumerable<ShiftTransferModel>> GetAllShiftAsync();
        public Task<ShiftTransferModel> GetShiftByIdAsync(Guid id);
        public Task<IList<ShiftsTransferModel>> GetUserShiftsPerPeriodAsync(Guid userId, AppDateOnly date);
		public Task<StatusModel> ModifyNewShiftsRotationAsync(Guid id, DateOnly period, List<ShiftsTransferModel> transfer);
        public Task<StatusModel> SetWorkingRotation(IFormFile file);
    }
}
