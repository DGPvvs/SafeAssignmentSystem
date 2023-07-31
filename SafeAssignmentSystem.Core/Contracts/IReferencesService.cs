namespace SafeAssignmentSystem.Core.Contracts
{
	using SafeAssignmentSystem.Common.Enums;
	using SafeAssignmentSystem.Core.Models.TransferModels.ReferencesTransferModels;
    using SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels;
    using System;
    using System.Threading.Tasks;


    /// <summary>
    /// Интерфейс дефиниращ сървис манипулиращ с данните за създаване на отчети
    /// </summary>
	public interface IReferencesService
    {
        /// <summary>
        /// Декларация на метод връщащ архивираните нарядите за технологична позиция
        /// </summary>
        /// <param name="positionId">Идентификатор на технологична позиция</param>
        /// <returns></returns>
        public Task<AllSafeAssignmentArchivedTransferModel> GetAllArchivedSafeAssignmentTechnologicalPositionAsync(Guid positionId);


        /// <summary>
        /// Декларация на метод връщащ състоянието на технологичните позиции
        /// в инсталация с идентификатор plantId според критериите на filter 
        /// </summary>
        /// <param name="plantId">Идентификатор на инсталация</param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Task<PositionInPlantTransferModel> GetTechnologicalPositionConditionAsync(Guid plantId, FilterCriteria filter);

	}
}
