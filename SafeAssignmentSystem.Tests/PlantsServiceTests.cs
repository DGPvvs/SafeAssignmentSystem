namespace SafeAssignmentSystem.Tests
{
    using Microsoft.AspNetCore.Identity;
    using Moq;
    using SafeAssignmentSystem.Core.Service;
    using SafeAssignmentSystem.DataBase.Data.Common;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using System.Linq;
    using System.Threading.Tasks;

    [TestFixture]
    public class PlantsServiceTests
    {
        private UserManager<ApplicationUser> userManager;

        [SetUp]
        public void Setup(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        [Test]
        public async Task GetAllComplexAsync_test()
        {
            var seed = new SeedsData();

            var mockRepo = new Mock<IRepository>();
            mockRepo
                .Setup(p => p.AllReadonly<ProductionComplex>())
                .Returns(seed.SeedComplex().AsQueryable());

            var service = new PlantsService(this.userManager, mockRepo.Object);

            var result = service.GetAllComplexAsync(false);
        }
    }
}
