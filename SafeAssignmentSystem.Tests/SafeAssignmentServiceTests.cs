namespace SafeAssignmentSystem.Tests
{
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Common.Enums;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels;
    using SafeAssignmentSystem.Core.Service;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;
    using SafeAssignmentSystem.Tests.UnitTests;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using static SafeAssignmentSystem.Common.ModelsConstants.DataModelsConstants;

    [TestFixture]
    public class SafeAssignmentServiceTests : UnitTestsBase
    {
        private ISafeAssignmentService safeAssignmentService;
        private Guid electricianId;
        private Guid operatorId;

        [SetUp]
        public void Setup()
        {
            this.safeAssignmentService = new SafeAssignmentService(this.repo);
            this.electricianId = Guid.Parse("3bd76d51-384b-4233-a83e-40e1e1a355dc");
            this.operatorId = Guid.Parse("822edebf-23a5-4373-b56d-94078d984192");
        }

        [Test]
        public async Task AllSafeAssigmentForPositionAndStatusAsyncCount()
        {
            var rnd = new Random();

            var allPositions = await this.repo
                .AllReadonly<TechnologicalPosition>()
                .AsNoTracking()
                .ToListAsync();

            var positionCounts = new Dictionary<Guid, int>();

            int n = 100;
            for (int i = 0; i < n; i++)
            {
                var position = allPositions.Skip(rnd.Next(allPositions.Count) - 1).Take(1).First();
                var safeAssignment = await this.CreateSafeAssignment(position);
                await this.safeAssignmentService.CreateSafeAssignmentAsync(safeAssignment);

                if (!positionCounts.ContainsKey(position.Id))
                {
                    positionCounts[position.Id] = 0;
                }

                positionCounts[position.Id]++;
            }

            foreach (var position in positionCounts)
            {
                var targetSA = await this.safeAssignmentService.
                    AllSafeAssigmentForPositionAndStatusAsync(position.Key, StatusFlagsEnum.Created);

                Assert.AreEqual(targetSA.Count(), position.Value);                
            }            
        }

        [Test]
        public async Task CreateSafeAssignmentAsync_Correct()
        {
            var rnd = new Random();

            var allPositions = await this.repo
                .AllReadonly<TechnologicalPosition>()
                .AsNoTracking()
                .ToListAsync();

            var position = allPositions.Skip(rnd.Next(allPositions.Count) - 1).Take(1).First();

            var safeAssignment = await this.CreateSafeAssignment(position);

            await this.safeAssignmentService.CreateSafeAssignmentAsync(safeAssignment);
            

        }

        private async Task<SafeAssignmentTransferModel> CreateSafeAssignment(TechnologicalPosition position)
        {
            var rnd = new Random();
            var plant = await this.repo
                .GetByIdAsync<PlantInstalation>(position.InstalationId);
            var complex = await this.repo
                .GetByIdAsync<ProductionComplex>(plant.ComplexId);

            string number = $"{rnd.Next(10)}{rnd.Next(10)}{rnd.Next(10)}{rnd.Next(10)}";


            var newSafeAssignment = new SafeAssignmentTransferModel()
            {
                Number = string.Format(SafeAssignmentDocumentConstants.Format_Number, complex.Name, plant.Name, number, DateOnly.FromDateTime(DateTime.Now).ToString(SafeAssignmentDocumentConstants.Date_Display_Format)),
                TechnologicalPositionId = position.Id,
                PersonRequestedOpeningOrderId = this.operatorId,
                Status = StatusFlagsEnum.Created
            };

            return newSafeAssignment;
        }
    }
}
