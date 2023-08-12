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
    using SafeAssignmentSystem.Tests.Models;
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
            Assert.ThrowsAsync<PlantNotFoundException>(async () => await this.referencesService.GetTechnologicalPositionConditionAsync(Guid.Empty, FilterCriteria.All));
        }

        //TODO: Не е довършен
        [Test]
        public async Task GetTechnologicalPositionConditionAsync_InWork()
        {            
            var plants = await this.repo.AllReadonly<PlantInstalation>()
                .AsNoTracking()
                .ToListAsync();

            var rnd = new Random();
            int n = 20;

            var l = new Dictionary<Guid, PlantTestModel>();

            foreach (var plant in plants)
            {
                var plantId = plant.Id;
                var positions = await this.choisPlantsService.ChoicesAllPositionInPlantAsync(plantId);

                if (positions.Count() > 0)
                {
                    if (!l.ContainsKey(plantId))
                    {
                        l.Add(plantId, new PlantTestModel(plantId));
                    }

                    foreach (var positionId in positions)
                    {
                        var position = await this.repo.GetByIdAsync<TechnologicalPosition>(positionId);

                        for (int i = 0; i < n; i++)
                        {
                            int index = rnd.Next(1, 5);

                            switch (index)
                            {
                                case 1:
                                    var safeAssignment = await this.CreateTestSafeAssignment(position);
                                    await this.SetTestSafeAssignmentInBase(safeAssignment);
                                    l[plantId].CountRequested += 1;
                                    break;
                                case 2:
                                    safeAssignment = await this.OpeningTestSafeAssignmentAsync(position);
                                    await this.SetTestSafeAssignmentInBase(safeAssignment);
                                    l[plantId].CountOpening += 1;
                                    break;
                                case 3:
                                    safeAssignment = await this.ClosingTestSafeAssignmentAsync(position);
                                    await this.SetTestSafeAssignmentInBase(safeAssignment);
                                    l[plantId].CountClosing += 1;
                                    break;
                                case 4:
                                    safeAssignment = await this.RequiredTestSafeAssignmentAsync(position);
                                    await this.SetTestSafeAssignmentInBase(safeAssignment);
                                    l[plantId].CountRequestedVoltageSupply += 1;
                                    break;
                                case 5:
                                    safeAssignment = await this.ArchivedTestSafeAssignmentAsync(position);
                                    await this.SetTestSafeAssignmentInBase(safeAssignment);
                                    l[plantId].CountArchive += 1;
                                    break;
                            }
                        }
                    }




                    //var safe = await this.referencesService.GetTechnologicalPositionConditionAsync(plant.Id, FilterCriteria.All);
                    //var safeUnderRepair = await this.referencesService.GetTechnologicalPositionConditionAsync(plant.Id, FilterCriteria.UnderRepair);
                    //var safeNoVoltageApplied = await this.referencesService.GetTechnologicalPositionConditionAsync(plant.Id, FilterCriteria.NoVoltageApplied);

                    //foreach (var position in safe.Positions)
                    //{
                    //    Assert.AreEqual(0, 0);
                    //}

                }


            }
        }
    }
}
