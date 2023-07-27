namespace SafeAssignmentSystem.Core.Contracts
{
	using SafeAssignmentSystem.Common.Enums;
	using SafeAssignmentSystem.Core.Models.TransferModels.ReferencesTransferModels;
	using System;
	using System.Threading.Tasks;

	public interface IReferencesService
    {
		/// <summary>
		/// Декларация на метод връщащ състоянието на технологичните позиции
		/// в инсталация с идентификатор plantId според критериите на filter 
		/// </summary>
		/// <param name="plantId">Идентификатор на инсталация</param>
		/// <param name="all"></param>
		/// <returns></returns>
		public Task<PositionInPlantTransferModel> GetTechnologicalPositionConditionAsync(Guid plantId, FilterCriteria filter);

	}
}
