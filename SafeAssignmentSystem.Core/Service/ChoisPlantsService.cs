namespace SafeAssignmentSystem.Core.Service
{
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.DataBase.Data.Common;
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Сървис имплементиращ методи за селекция
    /// </summary>
    public class ChoisPlantsService : IChoisPlantsService
    {        
        private readonly IRepository repo;

        /// <summary>
        /// Конструктор на сървиса менажиращ изборите
        /// </summary>
        /// <param name="repo"></param>
        public ChoisPlantsService(IRepository repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// Имплементация на метод селектиращ всички технологични позиции в инсталация с идентификатор plantId
        /// </summary>
        /// <param name="plantId">Идентификатор на инсталация</param>
        /// <returns></returns>
        public async Task<IEnumerable<Guid>> ChoicesAllPositionInPlantAsync(Guid plantId) => await this.repo.AllReadonly<TechnologicalPosition>()
            .Where(tp => tp.InstalationId.Equals(plantId))
            .Select(tp => tp.Id)
            .ToListAsync();
    }
}
