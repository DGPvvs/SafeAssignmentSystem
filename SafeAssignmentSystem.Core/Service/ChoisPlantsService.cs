namespace SafeAssignmentSystem.Core.Service
{
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Data;
    using System;
    using System.Threading.Tasks;

    public class ChoisPlantsService : IChoisPlantsService
    {
        private readonly SafeAssignmentDbContext context;
        private readonly IPlantsService service;

        /// <summary>
        /// Конструктор на сървиса менажиращ изборите
        /// </summary>
        /// <param name="context"></param>
        /// <param name="service"></param>
        public ChoisPlantsService(
            SafeAssignmentDbContext context,
            IPlantsService service)
        {
            this.context = context;
            this.service = service;
        }

        public Task<Guid> PlantChois()
        {
            throw new NotImplementedException();
        }
    }
}
