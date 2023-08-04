namespace SafeAssignmentSystem.Tests
{
    using Moq;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Service;
    using SafeAssignmentSystem.DataBase.Data.Common;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using SafeAssignmentSystem.Tests.UnitTests;
    using System.Linq;
    using System.Threading.Tasks;

    [TestFixture]
    public class PlantsServiceTests : UnitTestsBase
    {        
        private IPlantsService plantsService;
        
        

        [OneTimeSetUp]
        public void Setup()
        {
                         
        }

        [Test]
        public async Task GetAllComplexAsync_Test()
        {
            this.plantsService = new PlantsService(this.repo);

            var seed = new SeedsData();

            var mockRepo = new Mock<IRepository>();
            mockRepo
                .Setup(p => p.AllReadonly<ProductionComplex>())
                .Returns(seed.SeedComplex().AsQueryable());

            var service = new PlantsService(mockRepo.Object);

            var result = service.GetAllComplexAsync(false);
        }        
    }
}
