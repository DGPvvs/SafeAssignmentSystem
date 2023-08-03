namespace SafeAssignmentSystem.Tests
{
    using Moq;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Service;
    using SafeAssignmentSystem.DataBase.Data.Common;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData;
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;
    using SafeAssignmentSystem.Tests.UnitTests;
    using System;

    [TestFixture]
    public class ChoisPlantsServiceTest : UnitTestsBase
    {
        private IChoisPlantsService choisPlantsService;

        [OneTimeSetUp]
        public void Setup()
        {
            this.choisPlantsService = new ChoisPlantsService(this.repo);
        }

        [Test]
        public async Task ChoicesAllPositionInPlantAsync_Test_Positiv()
        {
            var rnd = new Random();

            var seed = new SeedsData();

            //var mockRepo = new Mock<IRepository>();
            //mockRepo
            //    .Setup(p => p.AllReadonly<TechnologicalPosition>())
            //    .Returns(seed.SeedTechnologicalPosition().AsQueryable());

            //var service = new ChoisPlantsService(mockRepo.Object);

            int count = 20;

            for (int i = 0; i < count; i++)
            {
                int countCollection = seed.SeedTechnologicalPosition().Count();
                Guid plantId = seed.SeedTechnologicalPosition().Skip(rnd.Next(countCollection - 1)).Take(1).First().Id;

                var target = seed.SeedTechnologicalPosition()
                    .Where(tp => tp.InstalationId.Equals(plantId))
                    .Select(tp => tp.Id)
                    .ToList();
                var result = new List<Guid>(await this.choisPlantsService.ChoicesAllPositionInPlantAsync(plantId));

                Assert.AreEqual(result.Count(), target.Count());
            }
        }
    }
}
