namespace SafeAssignmentSystem.Core.Service
{
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ChoisPlantsService : IChoisPlantsService
    {
        private readonly SafeAssignmentDbContext context;
        private readonly IPlantsService service;

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
