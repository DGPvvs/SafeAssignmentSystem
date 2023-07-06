namespace SafeAssignmentSystem.Core.Contracts
{
    using System;
    using System.Threading.Tasks;

    public interface IChoisPlantsService
    {
        public Task<Guid> PlantChois();
    }
}
