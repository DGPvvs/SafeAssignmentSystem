namespace SafeAssignmentSystem.Core.Service
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
	using SafeAssignmentSystem.Common.Exeptions;
	using SafeAssignmentSystem.Common.IO.Contracts;
	using SafeAssignmentSystem.Common.Notification;
	using SafeAssignmentSystem.Common.Overrides;
	using SafeAssignmentSystem.Core.Contracts;
	using SafeAssignmentSystem.Core.Data;
	using SafeAssignmentSystem.Core.IO;
	using SafeAssignmentSystem.Core.Models.StatusModels;
	using SafeAssignmentSystem.Core.Models.TransferModels;
	using SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels;
	using SafeAssignmentSystem.DataBase.Data.Common;
	using SafeAssignmentSystem.DataBase.Data.DatabaseModels.StaffsModels;
	using System;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using static SafeAssignmentSystem.Common.Notification.NotificationConstants;

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

		public async Task EditShiftAsync(ShiftTransferModel transfer)
		{
			var entity = await this.repo.All<WorkingShift>(ws => ws.Id == transfer.Id).FirstOrDefaultAsync();

			if (entity is null)
			{
				throw new NullReferenceException();
			}

			var startTime = new DateTime(1, 1, 1) + transfer.Start.ToTimeSpan();
			var endTime = new DateTime(1, 1, 1) + transfer.End.ToTimeSpan();

			if (transfer.Start > transfer.End)
			{
				endTime = new DateTime(1, 1, 2) + transfer.End.ToTimeSpan();
			}

			entity.StartTime = startTime;
			entity.EndTime = endTime;

			await this.repo.SaveChangesAsync();
		}

		public async Task<IEnumerable<ShiftTransferModel>> GetAllShiftAsync()
		{
			var entity = await this.repo.AllReadonly<WorkingShift>().ToListAsync();

			var result = entity.Select(ws => new ShiftTransferModel()
			{
				Id = ws.Id,
				ShiftName = ws.ShiftName,
				Start = new TimeOnly(ws.StartTime.Hour, ws.StartTime.Minute),
				End = new TimeOnly(ws.EndTime.Hour, ws.EndTime.Minute)
			}).ToList();

			return result;
		}

		public async Task<ShiftTransferModel> GetShiftByIdAsync(Guid id)
		{
			var entity = await this.repo.AllReadonly<WorkingShift>(ws => ws.Id == id).FirstOrDefaultAsync();

			return new ShiftTransferModel()
			{
				Id = entity.Id,
				ShiftName = entity.ShiftName,
				Start = new TimeOnly(entity.StartTime.Hour, entity.StartTime.Minute),
				End = new TimeOnly(entity.EndTime.Hour, entity.EndTime.Minute)
			};
		}

		public async Task<IList<ShiftsTransferModel>> GetUserShiftsPerPeriodAsync(Guid userId, AppDateOnly date)
		{
			InstantConstants baseTime = new InstantConstants();

			DateTime startDate = baseTime.referenceDateTime.AddYears(date.DateOnly.Year - 1).AddMonths(date.DateOnly.Month - 1);

			DateTime endDate = baseTime.referenceDateTime.AddYears(date.DateOnly.Year - 1).AddMonths(date.DateOnly.Month);

			var userShiftsPerPeriod = await this.repo.AllReadonly<ChangedSchedule>()
				.Where(cs => cs.ApplicationUserId == userId && (cs.Date >= startDate && cs.Date < endDate))
				.Select(cs => new EditUserShiftTransferModel()
				{
					UserId = cs.ApplicationUserId,
					Date = cs.Date,
					ShiftName = cs.Shift.ShiftName,
					ShiftId = cs.ShiftId
				})
				.ToListAsync();

			List<ShiftsTransferModel> userShifts = new List<ShiftsTransferModel>();

			while (startDate < endDate)
			{
				var userShift = userShiftsPerPeriod.FirstOrDefault(s => s.Date.Year == startDate.Year &&
					s.Date.Month == startDate.Month &&
					s.Date.Day == startDate.Day);

				ShiftsTransferModel shift = new ShiftsTransferModel()
				{
					Date = DateOnly.FromDateTime(startDate)
				};

				if (!(userShift is null))
				{
					shift.ShiftName = userShift.ShiftName;
					shift.ShiftId = userShift.ShiftId;
				}

				userShifts.Add(shift);

				startDate = startDate.AddDays(1);
			}

			return userShifts;
		}

		public async Task<StatusModel> ModifyNewShiftsRotationAsync(Guid id, DateOnly period, List<ShiftsTransferModel> transfer)
		{
			var result = new StatusModel()
			{
				Success = false
			};

			try
			{
				var currentShifts = await this.repo.AllReadonly<ChangedSchedule>()
				.Where(cs => cs.ApplicationUserId == id &&
					cs.Date.Year == period.Year &&
					cs.Date.Month == period.Month)
				.ToListAsync();

				var adds = transfer
					.Select(st => new ChangedSchedule()
					{
						ApplicationUserId = id,
						ShiftId = st.ShiftId,
						Date = new DateTime(st.Date.Year, st.Date.Month, st.Date.Day)
					})
					.ToList();

				this.repo.DeleteRange<ChangedSchedule>(currentShifts);
				await this.repo.AddRangeAsync<ChangedSchedule>(adds);
				await this.repo.SaveChangesAsync();
			}
			catch (Exception)
			{
				result.Description = Shift_Roptatin_Edit_Fail;

				return result;
			}

			result.Success = true;
			result.Description = Shift_Roptatin_Edit_Success;

			return result;
		}

        public async Task<StatusModel> SetWorkingRotation(IFormFile file)
        {
            var result = new StatusModel()
            {
                Success = false
            };

			var reader = new LoadWorkingRotationFromFile();

			try
			{
				var loadingData = reader.ReadData(file, new List<ChangedScheduleTransferModel>());
			}
			catch (Exception)
			{
				result.Description = Shift_Roptatin_Edit_Fail;
			}

			return result;
        }
    }
}
