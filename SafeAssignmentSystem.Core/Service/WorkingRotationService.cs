﻿namespace SafeAssignmentSystem.Core.Service
{
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Identity;
	using Microsoft.EntityFrameworkCore;
	using SafeAssignmentSystem.Common.Exeptions;
	using SafeAssignmentSystem.Common.IO.Contracts;
	using SafeAssignmentSystem.Common.Notification;
	using SafeAssignmentSystem.Common.Overrides;
	using SafeAssignmentSystem.Core.Contracts;
	using SafeAssignmentSystem.Core.Models.StatusModels;
	using SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels;
	using SafeAssignmentSystem.DataBase.Data.Common;
	using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
	using SafeAssignmentSystem.DataBase.Data.DatabaseModels.StaffsModels;
	using System;
	using System.Collections.Generic;
	using System.Threading.Tasks;


	using static SafeAssignmentSystem.Common.Notification.NotificationConstants;

    /// <summary>
    /// Сървис манипулиращ с данните за смените и сменните графици
    /// </summary>
    public class WorkingRotationService : IWorkingRotationService
	{
		private readonly UserManager<ApplicationUser> userManager;
		private readonly IRepository repo;
        private readonly IReader reader;

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="userManager"></param>
		/// <param name="repo"></param>
		/// <param name="reader"></param>
        public WorkingRotationService(
            UserManager<ApplicationUser> userManager,
			IRepository repo,
            IReader reader)
		{
			this.userManager = userManager;
			this.repo = repo;
			this.reader = reader;
		}

        /// <summary>
        /// Имплементация метод добавящ нова смяна в базата данни
        /// </summary>
        /// <param name="transfer">Модел с данни за новата смяна</param>
        /// <returns></returns>
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

			if (transfer.Start >= transfer.End)
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

        /// <summary>
        /// Имплементация метод за редакция на съществуваща смяна
        /// </summary>
        /// <param name="transfer">Модел с данни за смяната</param>
        /// <returns></returns>
        public async Task EditShiftAsync(ShiftTransferModel transfer)
		{
			var entity = await this.repo.All<WorkingShift>(ws => ws.Id == transfer.Id).FirstOrDefaultAsync();

			if (entity is null)
			{
				throw new NullReferenceException();
			}

			var startTime = new DateTime(1, 1, 1) + transfer.Start.ToTimeSpan();
			var endTime = new DateTime(1, 1, 1) + transfer.End.ToTimeSpan();

			if (transfer.Start >= transfer.End)
			{
				endTime = new DateTime(1, 1, 2) + transfer.End.ToTimeSpan();
			}

			entity.StartTime = startTime;
			entity.EndTime = endTime;

			this.repo.Update(entity);
			await this.repo.SaveChangesAsync();
		}

        /// <summary>
        /// Имплементация на метод връщащ колекция с всички смени регистрирани в базата данни
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Имплементация на метод връщащ смяна с идентификатор id
        /// </summary>
        /// <param name="id">Идентификатор на смяна</param>
        /// <returns></returns>
        public async Task<ShiftTransferModel> GetShiftByIdAsync(Guid id)
		{
			var entity = await this.repo.AllReadonly<WorkingShift>(ws => ws.Id == id).FirstOrDefaultAsync();

			if (entity is null)
			{
				throw new NullReferenceException(nameof(entity));
			}

			return new ShiftTransferModel()
			{
				Id = entity!.Id,
				ShiftName = entity.ShiftName,
				Start = new TimeOnly(entity.StartTime.Hour, entity.StartTime.Minute),
				End = new TimeOnly(entity.EndTime.Hour, entity.EndTime.Minute)
			};
		}

        /// <summary>
        /// Имплементира метод връщащ колекция със смените на потребител за месец указан от date
		/// Данните се вземат от таблицата със сменни графици
        /// </summary>
        /// <param name="userId">Идентификатор на потребител</param>
        /// <param name="date">Дата сочеща месеца за който да бъдат взети смените</param>
        /// <returns></returns>
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

        /// <summary>
        /// Имплементира метод редактиращ сменния график на потребител с идентификатор id
        /// съобразно списъка в transfer 
        /// </summary>
        /// <param name="id">Идентификатор на потребител</param>
        /// <param name="period">Година и месец</param>
        /// <param name="transfer">Списък със смени</param>
        /// <returns></returns>
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


		/// <summary>
		/// Имплементация на метод зареждаща сменен график от файл
		/// </summary>
		/// <param name="file"></param>
		/// <param name="userName"></param>
		/// <returns></returns>
        public async Task<StatusModel> SetWorkingRotation(IFormFile file, string userName)
        {
            var result = new StatusModel()
            {
                Success = false
            };

			try
			{
				var loadingData = this.reader.ReadData(file, new List<Models.TransferModels.ChangedScheduleTransferModel>());  

                var operatorUsers = await this.userManager.GetUsersInRoleAsync(RoleConstants.Operator);
                var electricianUsers = await this.userManager.GetUsersInRoleAsync(RoleConstants.Electrician);

                var workingShifts = await this.GetAllShiftAsync();

				foreach (var shiftGrafik in loadingData)
				{
					var user = operatorUsers.FirstOrDefault(u => u.UserWorkNumber == shiftGrafik.UseNumber);

					if (user is null)
					{
						user = electricianUsers.FirstOrDefault(u => u.UserWorkNumber == shiftGrafik.UseNumber);
                    }                    

                    if (!(user is null))
					{
                        List<ShiftsTransferModel> schedules = new List<ShiftsTransferModel>();
						var period = shiftGrafik.Date;

                        for (int i = 0; i < shiftGrafik.MonthlyDistribution.Length; i++)
						{
                            var shiftForDay = shiftGrafik.MonthlyDistribution[i];

							var shift = workingShifts.FirstOrDefault(ws => ws.ShiftName.ToUpper().Equals(shiftForDay.ToUpper()));

                            if (!(shift is null))
							{
								var date = new DateOnly(shiftGrafik.Date.Year, shiftGrafik.Date.Month, shiftGrafik.Date.Day + i);
                                ShiftsTransferModel newChangedSchedule = new ShiftsTransferModel()
								{
									ShiftId = shift.Id,
									Date = date
								};

								schedules.Add(newChangedSchedule);
							}
						}

						result = await this.ModifyNewShiftsRotationAsync(user.Id, period, schedules);
                    }					
                }

				result.Success = true;
				result.Description = Shift_Roptatin_Edit_Success;
            }
			catch (Exception)
			{
				result.Description = Shift_Roptatin_Edit_Fail;
			}

			return result;
        }
    }
}
