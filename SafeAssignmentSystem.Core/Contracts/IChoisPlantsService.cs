namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Интерфейс деклариращ методи за селекция
    /// </summary>
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
