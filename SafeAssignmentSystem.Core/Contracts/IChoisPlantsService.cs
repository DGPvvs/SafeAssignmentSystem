namespace SafeAssignmentSystem.Core.Contracts
{
    using System;
    using System.Threading.Tasks;

    public interface IChoisPlantsService
    {
        /// <summary>
        /// Деклариране на метод селектиращ всички технологични позиции в инсталация с идентификатор plantId
        /// </summary>
        /// <param name="plantId">Идентификатор на инсталация</param>
        /// <returns></returns>
        public Task<IEnumerable<Guid>> ChoicesAllPositionInPlantAsync(Guid plantId);
    }
}
