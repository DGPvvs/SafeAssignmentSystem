namespace SafeAssignmentSystem.Tests
{
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Common.Enums;
    using SafeAssignmentSystem.Common.Exceptions;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Service;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.SafeAssignmentDocumentModels;
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;
    using SafeAssignmentSystem.Tests.UnitTests;
    using System;

    [TestFixture]
    public class ReferencesServiceTest : UnitTestsBase
    {        
        private IChoisPlantsService choisPlantsService;
        private ISafeAssignmentService safeAssignmentService;
        private IReferencesService referencesService;

        [SetUp]
        public void Setup()
        {
            this.safeAssignmentService = new SafeAssignmentService(this.repo);
            this.choisPlantsService = new ChoisPlantsService(this.repo);

            this.referencesService = new ReferencesService(repo, this.choisPlantsService, this.safeAssignmentService);

            this.electricianId = Guid.Parse("3bd76d51-384b-4233-a83e-40e1e1a355dc");
            this.operatorId = Guid.Parse("822edebf-23a5-4373-b56d-94078d984192");
        }

        [Test]
        public async Task GetAllArchivedSafeAssignmentTechnologicalPositionAsync_Corect()
        {
            int n = 20;
            var rnd = new Random();

            var allPositions = await this.repo
                .AllReadonly<TechnologicalPosition>()
                .AsNoTracking()
                .ToListAsync();

            var rndCountPerPosition = new Dictionary<Guid, int>();

            foreach (var position in allPositions)
            {
                int count = rnd.Next(1, n + 1);
                rndCountPerPosition[position.Id] = count;
            }

            foreach (var positionKvP in rndCountPerPosition)
            {
                var position = await this.repo
                    .GetByIdAsync<TechnologicalPosition>(positionKvP.Key);

                for (int i = 0; i < positionKvP.Value; i++)
                {
                    var safeAssignment = await this.ArchivedTestSafeAssignmentAsync(position);

                    await this.SetTestSafeAssignmentInBase(safeAssignment);

                    var targets = await this.repo
                        .AllReadonly<SafeAssignmentDocument>()
                        .AsNoTracking()
                        .Where(sa => sa.Number.Equals(safeAssignment.Number))
                        .ToListAsync();

                    var targetId = targets.FirstOrDefault()!.Id;
                }
            }

            foreach (var positionKvP in rndCountPerPosition)
            {
                var targets = await this.referencesService.GetAllArchivedSafeAssignmentTechnologicalPositionAsync(positionKvP.Key);

                var position = await this.repo.GetByIdAsync<TechnologicalPosition>(positionKvP.Key);
                var plant = await this.repo.GetByIdAsync<PlantInstalation>(position.InstalationId);
                var complex = await this.repo.GetByIdAsync<ProductionComplex>(plant.ComplexId);

                Assert.NotNull(targets);
                Assert.AreEqual(targets.Position, position.Name);
                Assert.AreEqual(targets.Plant, plant.FullName);
                Assert.AreEqual(targets.Complex, complex.FullName);
                Assert.AreEqual(targets.SafeAssignments.Count(), positionKvP.Value);                
            }            
        }

        [Test]
        public async Task GetAllArchivedSafeAssignmentTechnologicalPositionAsync_ThrowException()
        {
            Assert.ThrowsAsync<TechnologicalPositionException>(async () => await this.referencesService.GetAllArchivedSafeAssignmentTechnologicalPositionAsync(Guid.Empty));
        }

        [Test]
        public async Task GetTechnologicalPositionConditionAsync_ThrowException()
        {
            Assert.ThrowsAsync<PlantNotFoundException>( async () => await this.referencesService.GetTechnologicalPositionConditionAsync(Guid.Empty, FilterCriteria.All));
        }
    }
}
