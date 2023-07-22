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
    using System.Threading.Tasks;

    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;

    public class SafeAssignmentService : ISafeAssignmentService
    {
        private readonly IRepository repo;

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
        public async Task<IEnumerable<SafeAssignmentTransferModel>> AllSafeAssigmentForPositionAndStatus(Guid positionId, StatusFlagsEnum status)
        {
            var transfer = await this.repo.AllReadonly<SafeAssignmentDocument>()
                .Where(sa => sa.TechnologicalPositionId.Equals(positionId) && sa.Status.Equals(status))
                .AsNoTracking()
                .Select(sa => new SafeAssignmentTransferModel()
                {
                    Id = sa.Id,
                    Number = sa.Number,
                    TechnologicalPositionId = sa.TechnologicalPositionId,
                    PersonRequestedOpeningOrderId = sa.PersonRequestedOpeningOrderId,
                    OpeningDate = sa.OpeningDate.Equals(null) ? null : new DateOnly(sa.OpeningDate.Value.Year,
                                                                                    sa.OpeningDate.Value.Month,
                                                                                    sa.OpeningDate.Value.Day),
                    OpeningTime = sa.OpeningDate.Equals(null) ? null : new TimeOnly(sa.OpeningDate.Value.Hour,
                                                                                    sa.OpeningDate.Value.Minute),
                    ЕlectricianOpeningOrderId = sa.ЕlectricianOpeningOrderId
				})
                .ToListAsync();

            return transfer;
        }

		/// <summary>
		/// Декларация на метод завеждащ наряд за позиция, указана в transfer 
		/// </summary>
		/// <param name="transfer">Транспортен модел на наряда</param>
		/// <returns></returns>
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

		/// <summary>
		/// Имплементация на метод връщащ наряд с идентификатор safeAssignmentId
		/// </summary>
		/// <param name="safeAssignmentId">Идентификатор на наряд</param>
		/// <returns></returns>
		public async Task<SafeAssignmentTransferModel> GetSafeAssignmentById(Guid safeAssignmentId)
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
                Number = transfer.Number,
                TechnologicalPositionId = transfer.TechnologicalPositionId,
                PersonRequestedOpeningOrderId = transfer.PersonRequestedOpeningOrderId,
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
		public async Task<StatusModel> OpeningSafeAssignment(Guid safeAssignmentId, Guid userId)
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
                result.Description = Opening_SafeAssignment_Document_Fail;
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
	}
}
