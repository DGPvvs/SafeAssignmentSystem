namespace SafeAssignmentSystem.Tests
{
    using Moq;
    using SafeAssignmentSystem.Core.Service;
    using SafeAssignmentSystem.DataBase.Data.Common;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData;
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;
    using System;

    [TestFixture]
    public class ChoisPlantsServiceTest
    {
        [SetUp]
        public void Setup()
        {            
        }

        [Test]
        public async Task ChoicesAllPositionInPlantAsync_Test_Positiv()
        {
            var rnd = new Random();

            var seed = new SeedsData();

            var mockRepo = new Mock<IRepository>();
            mockRepo
                .Setup(p => p.AllReadonly<TechnologicalPosition>())
                .Returns(await Task.FromResult(seed.SeedTechnologicalPosition().AsQueryable()));

            var service = new ChoisPlantsService(mockRepo.Object);

            int count = 20;

            for (int i = 0; i < count; i++)
            {
                int countCollection = seed.SeedTechnologicalPosition().Count();
                Guid plantId = seed.SeedTechnologicalPosition().Skip(rnd.Next(countCollection - 1)).Take(1).First().Id;
                var result = await service.ChoicesAllPositionInPlantAsync(plantId);

                var target = seed.SeedTechnologicalPosition().Where(tp => tp.InstalationId.Equals(plantId));
                Assert.Equals(result.Count(), target.Count());
            }
        }
    }
}
