namespace SafeAssignmentSystem.Core.Service
{
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Common.Enums;
    using SafeAssignmentSystem.Common.Exceptions;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels;
    using SafeAssignmentSystem.DataBase.Data.Common;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.SafeAssignmentDocumentModels;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;

    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;

    /// <summary>
    /// Сървис манипулиращ с данните при работа с наряди
    /// </summary>
    public class SafeAssignmentService : ISafeAssignmentService
    {
        private readonly IRepository repo;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="repo"></param>
        public SafeAssignmentService(IRepository repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// Имплементация на метод връщащ всички заведени наряди за технологична позиция
        /// и със статус указан от status 
        /// </summary>
        /// <param name="positionId">Идентификатор на технологична позиция</param>
        /// /// <param name="status">Идентификатор на статус</param>
        /// <returns></returns>
        public async Task<IEnumerable<SafeAssignmentTransferModel>> AllSafeAssigmentForPositionAndStatusAsync(Guid positionId, StatusFlagsEnum status)
        {
            var transfer = await this.repo.AllReadonly<SafeAssignmentDocument>()
                .Where(sa => sa.TechnologicalPositionId.Equals(positionId) && sa.Status.Equals(status))
                .AsNoTracking()
                .Select(sa => new SafeAssignmentTransferModel()
                {
                    Id = sa.Id,
                    Number = WebUtility.HtmlDecode(sa.Number),
                    TechnologicalPositionId = sa.TechnologicalPositionId,
                    PersonRequestedOpeningOrderId = sa.PersonRequestedOpeningOrderId,
                    OpeningDate = sa.OpeningDate.Equals(null) ? null : new DateOnly(sa.OpeningDate.Value.Year,
                                                                                    sa.OpeningDate.Value.Month,
                                                                                    sa.OpeningDate.Value.Day),
                    OpeningTime = sa.OpeningDate.Equals(null) ? null : new TimeOnly(sa.OpeningDate.Value.Hour,
                                                                                    sa.OpeningDate.Value.Minute),
                    ЕlectricianOpeningOrderId = sa.ЕlectricianOpeningOrderId,
                    ClosingDate = sa.ClosingDate.Equals(null) ? null : new DateOnly(sa.ClosingDate.Value.Year,
                                                                                    sa.ClosingDate.Value.Month,
                                                                                    sa.ClosingDate.Value.Day),
                    ClosingTime = sa.ClosingDate.Equals(null) ? null : new TimeOnly(sa.ClosingDate.Value.Hour,
                                                                                    sa.ClosingDate.Value.Minute),
                    ЕlectricianClosingOrderId = sa.ЕlectricianClosingOrderId,
                    PersonRequestedVoltageSupplyId = sa.PersonRequestedVoltageSupplyId,
                    ElectricianAppliedVoltageId = sa.ElectricianAppliedVoltageId
                })
                .ToListAsync();

            return transfer;
        }

        /// <summary>
        /// Имплементация на метод създаващ заявка за подаване на напрежение
        /// за технологична позиция с идентификатор positionId
        /// и вдигащ статус StatusFlagsEnum.Archived на закритите наряди
        /// за указаната позиция
        /// </summary>
        /// <param name="id">Идентификатор на потребител</param>
        /// <param name="positionId">Идентификатор на позиция</param>
        /// <returns></returns>
        public async Task<StatusModel> AppliedSafeAssignmentAsync(Guid id, Guid positionId)
        {
            StatusModel result = new StatusModel()
            {
                Success = false,
            };

            var safeAssigmentsRequired = await this.repo.All<SafeAssignmentDocument>()
                .Where(sa => sa.TechnologicalPositionId.Equals(positionId) && sa.Status.Equals(StatusFlagsEnum.Required))
                .ToListAsync();

            var safeAssigmentsClosed = await this.repo.All<SafeAssignmentDocument>()
                    .Where(sa => sa.TechnologicalPositionId.Equals(positionId) && sa.Status.Equals(StatusFlagsEnum.Closing))
                    .ToListAsync();

            if (safeAssigmentsRequired.Count > 0)
            {
                foreach (var safeAssigment in safeAssigmentsRequired)
                {
                    safeAssigment.ElectricianAppliedVoltageId = id;
                    safeAssigment.Status = StatusFlagsEnum.Archived;
                }

                
                foreach (var safeAssigment in safeAssigmentsClosed)
                {
                    safeAssigment.ElectricianAppliedVoltageId = id;
                    safeAssigment.PersonRequestedVoltageSupplyId = id;
                    safeAssigment.Status = StatusFlagsEnum.Archived;
                }

                this.repo.UpdateRange(safeAssigmentsRequired);
                this.repo.UpdateRange(safeAssigmentsClosed);
            }           

            try
            {
                await this.repo.SaveChangesAsync();

                result.Success = true;
                result.Description = Archived_SafeAssignment_Document_Success;
            }
            catch (Exception)
            {
                result.Success = false;
                result.Description = Request_SafeAssignment_Document_Fail;
            }

            return result;

        }

        /// <summary>
        /// Имплементация на метод закриващ наряд с идентификатор safeAssignmentId
        /// Наряда се закрива от потребител с идентификатор userId 
        /// </summary>
        /// <param name="safeAssignmentId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<StatusModel> ClosingSafeAssignmentAsync(Guid safeAssignmentId, Guid userId)
		{
			StatusModel result = new StatusModel()
			{
				Success = false
			};

			var safeAssignment = await this.repo.All<SafeAssignmentDocument>()
				.Where(sa => sa.Id.Equals(safeAssignmentId))
				.FirstOrDefaultAsync();

			if (safeAssignment is null)
			{
				result.Description = SafeAssignment_Not_Exist;
                return result;
			}
			else
			{
				safeAssignment.ЕlectricianClosingOrderId = userId;
				safeAssignment.ClosingDate = DateTime.Now;
				safeAssignment.Status = StatusFlagsEnum.Closing;

				try
				{
					this.repo.Update(safeAssignment);
					await this.repo.SaveChangesAsync();
				}
				catch (Exception)
				{
					result.Description = Closing_SafeAssignment_Document_Fail;
					return result;
				}
			}

			result.Success = true;
			result.Description = Closing_SafeAssignment_Document_Success;

			return result;
		}

		/// <summary>
		/// Имплементация на метод завеждащ наряд за позиция, указана в transfer 
		/// </summary>
		/// <param name="transfer">Транспортен модел на наряда</param>
		/// <returns></returns>
		public async Task<StatusModel> CreateSafeAssignmentAsync(SafeAssignmentTransferModel transfer)
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

		/// <summary>
		/// Имплементация на метод връщащ наряд с идентификатор safeAssignmentId
		/// </summary>
		/// <param name="safeAssignmentId">Идентификатор на наряд</param>
		/// <returns></returns>
		public async Task<SafeAssignmentTransferModel> GetSafeAssignmentByIdAsync(Guid safeAssignmentId)
		{
            var transfer = await this.repo.AllReadonly<SafeAssignmentDocument>()
                .Where(sa => sa.Id.Equals(safeAssignmentId))
                .FirstOrDefaultAsync();

            if (transfer is null)
            {
                throw new SafeAssignmentNotExistException();
            }

            var result = new SafeAssignmentTransferModel()
            {
                Id = safeAssignmentId,
                Number = WebUtility.HtmlDecode(transfer.Number),
                TechnologicalPositionId = transfer.TechnologicalPositionId,
                PersonRequestedOpeningOrderId = transfer.PersonRequestedOpeningOrderId,
				OpeningDate = transfer.OpeningDate.Equals(null) ? null : new DateOnly(transfer.OpeningDate.Value.Year,
																					transfer.OpeningDate.Value.Month,
																					transfer.OpeningDate.Value.Day),
				OpeningTime = transfer.OpeningDate.Equals(null) ? null : new TimeOnly(transfer.OpeningDate.Value.Hour,
																					transfer.OpeningDate.Value.Minute),
				ЕlectricianOpeningOrderId = transfer.ЕlectricianOpeningOrderId,
                ClosingDate = transfer.ClosingDate.Equals(null) ? null : new DateOnly(transfer.ClosingDate.Value.Year,
                                                                                    transfer.ClosingDate.Value.Month,
                                                                                    transfer.ClosingDate.Value.Day),
                ClosingTime = transfer.ClosingDate.Equals(null) ? null : new TimeOnly(transfer.ClosingDate.Value.Hour,
                                                                                    transfer.ClosingDate.Value.Minute),
                ЕlectricianClosingOrderId = transfer.ЕlectricianClosingOrderId,
                PersonRequestedVoltageSupplyId = transfer.PersonRequestedVoltageSupplyId,
                ElectricianAppliedVoltageId = transfer.ElectricianAppliedVoltageId,
                Status = transfer.Status
            };
            
            return result;
		}

		/// <summary>
		/// Имплементация на метод откриващ наряд с идентификатор safeAssignmentId
		/// </summary>
		/// <param name="safeAssignmentId">Идентификатор на наряд</param>
		/// <param name="userId">Идентификатор на потребител откриващ наряда</param>
		/// <returns></returns>
		public async Task<StatusModel> OpeningSafeAssignmentAsync(Guid safeAssignmentId, Guid userId)
		{
			StatusModel result = new StatusModel()
			{
				Success = false
			};

			var safeAssignment = await this.repo.All<SafeAssignmentDocument>()
                .Where(sa => sa.Id.Equals(safeAssignmentId))
                .FirstOrDefaultAsync();

            if (safeAssignment is null)
            {
                result.Description = SafeAssignment_Not_Exist;
            }
            else
            {
                safeAssignment.ЕlectricianOpeningOrderId = userId;
                safeAssignment.OpeningDate = DateTime.Now;
                safeAssignment.Status = StatusFlagsEnum.Opening;

				try
				{
					this.repo.Update(safeAssignment);
                    await this.repo.SaveChangesAsync();
				}
				catch (Exception)
				{
					result.Description = Opening_SafeAssignment_Document_Fail;
                    return result;
				}
			}

            result.Success = true;
            result.Description = Opening_SafeAssignment_Document_Success;

            return result;
		}

        /// <summary>
        /// Имплементация на метод създаващ заявка за подаване на напрежение 
		/// за технологична позиция с идентификатор positionId
		/// и вдигащ статус StatusFlagsEnum.Required на закритите наряди
		/// за указаната позиция 
        /// </summary>
        /// <param name="positionId">Идентификатор на позиция</param>
        /// <param name="id">Идентификатор на потребител</param>
        /// <returns></returns>
        public async Task<StatusModel> RequestedSafeAssignmentAsync(Guid id, Guid positionId)
        {
            StatusModel result = new StatusModel()
            {
                Success = false
            };

            var safeAssigments = await this.repo.All<SafeAssignmentDocument>()
                .Where(sa => sa.TechnologicalPositionId.Equals(positionId) && sa.Status.Equals(StatusFlagsEnum.Closing))
                .ToListAsync();

            foreach (var safeAssigment in safeAssigments)
            {
                safeAssigment.PersonRequestedVoltageSupplyId = id;
                safeAssigment.Status = StatusFlagsEnum.Required;
            }

            this.repo.UpdateRange(safeAssigments);

            try
            {
                await this.repo.SaveChangesAsync();

                result.Success = true;
                result.Description = Request_SafeAssignment_Document_Success;
            }
            catch (Exception)
            {
                result.Description = Request_SafeAssignment_Document_Fail;
            }

            return result;
        }
    }
}
