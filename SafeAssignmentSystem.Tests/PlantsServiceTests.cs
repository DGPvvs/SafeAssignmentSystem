namespace SafeAssignmentSystem.Tests
{
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Common.Exeptions;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels;
    using SafeAssignmentSystem.Core.Service;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using SafeAssignmentSystem.Tests.UnitTests;
    using System.Threading.Tasks;
    using static SafeAssignmentSystem.Common.Notification.ConditionConstants;

    [TestFixture]
    public class PlantsServiceTests : UnitTestsBase
    {        
        private IPlantsService plantsService;        

        [SetUp]
        public void Setup()
        {
            this.plantsService = new PlantsService(this.repo);
        }

        [Test]
        public async Task AddComplexAsync_AddNewComplex()
        {
            int n = 20;

            var newComplexList = new List<ComplexTransferModel>();

            for (int i = 0; i < n; i++)
            {                
                var newComplex = new ComplexTransferModel()
                {
                    FullName = $"Инсталации в ликвидация {DateTime.Now}{i}",
                    Name = $"ИвЛ {i}",
                    IsDeleted = false
                };

                await this.plantsService.AddComplexAsync(newComplex);

                newComplexList.Add(newComplex);                

                Thread.Sleep(500);
            }

            foreach (var comlex in newComplexList)
            {
                var model = await this.repo.AllReadonly<ProductionComplex>()
                    .FirstOrDefaultAsync(c => c.Name == comlex.Name && c.FullName == comlex.FullName && !c.IsDeleted);

                Assert.IsNotNull(model);
                Assert.AreEqual(model.FullName, comlex.FullName);
                Assert.AreEqual(model.Name, comlex.Name);
                Assert.AreEqual(model.IsDeleted, comlex.IsDeleted);
            }
        }

        [Test]
        public async Task AddComplexAsync_AddExistingComplexByName()
        {
            int n = 20;
            var newComplexList = new List<ComplexTransferModel>();

            for (int i = 0; i < n; i++)
            {
                var newComplex = new ComplexTransferModel()
                {
                    FullName = $"Инсталации в ликвидация {i}",
                    Name = $"ИвЛ {i}",
                    IsDeleted = false
                };

                await this.plantsService.AddComplexAsync(newComplex);

                newComplexList.Add(newComplex);
            }

            foreach (var complex in newComplexList)
            {
                var newComplex = new ComplexTransferModel()
                {
                    FullName = "CPL",
                    Name = complex.Name,
                    IsDeleted = false
                };
                Assert.ThrowsAsync<IdentityЕxception>(async () => { await this.plantsService.AddComplexAsync(newComplex); });
            }
        }

        [Test]
        public async Task AddComplexAsync_AddExistingComplexByFullName()
        {
            int n = 20;
            var newComplexList = new List<ComplexTransferModel>();

            for (int i = 0; i < n; i++)
            {
                var newComplex = new ComplexTransferModel()
                {
                    FullName = $"Инсталации в ликвидация {i}",
                    Name = $"ИвЛ {i}",
                    IsDeleted = false
                };

                await this.plantsService.AddComplexAsync(newComplex);

                newComplexList.Add(newComplex);
            }

            foreach (var complex in newComplexList)
            {
                var newComplex = new ComplexTransferModel()
                {
                    FullName = complex.FullName,
                    Name = "CPL",
                    IsDeleted = false
                };
                Assert.ThrowsAsync<IdentityЕxception>(async () => { await this.plantsService.AddComplexAsync(newComplex); });
            }
        }

        [Test]
        public async Task AddComplexAsync_AddExistingDeletedComplexByName()
        {
            int n = 20;
            for (int i = 0; i < n; i++)
            {
                var newComplex = new ComplexTransferModel()
                {
                    FullName = $"Инсталации в ликвидация {i}",
                    Name = $"ИвЛ {i}",
                    IsDeleted = false
                };

                await this.plantsService.AddComplexAsync(newComplex);
            }

            var rnd = new Random();
            var seeder = await this.repo.AllReadonly<ProductionComplex>().Where(c => c.PlantInstalations.Count.Equals(0)).ToListAsync();
            int countCollection = seeder.Count();
            

            for (int i = 0; i < n; i++)
            {
                var complex = seeder.Skip(rnd.Next(countCollection - 1)).Take(1).First();

                await this.plantsService.ChangeDeleteStatusComplexAsync(complex.Id, IsDeletedCondition.Deleted);

                var newComplex = new ComplexTransferModel()
                {
                    FullName = $"ИвЛ {i}",
                    Name = complex.Name,
                    IsDeleted = false
                };

                await this.plantsService.AddComplexAsync(newComplex);

                var result = await this.context.ProductionComplexes.Where(c => c.Id.Equals(complex.Id)).FirstOrDefaultAsync();

                Assert.NotNull(result);
                Assert.IsFalse(result.IsDeleted);
            }
        }

        [Test]
        public async Task AddComplexAsync_AddExistingDeletedComplexByFullName()
        {
            int n = 20;
            for (int i = 0; i < n; i++)
            {
                var newComplex = new ComplexTransferModel()
                {
                    FullName = $"Инсталации в ликвидация {i}",
                    Name = $"ИвЛ {i}",
                    IsDeleted = false
                };

                await this.plantsService.AddComplexAsync(newComplex);
            }

            var rnd = new Random();
            var seeder = await this.repo.AllReadonly<ProductionComplex>().Where(c => c.PlantInstalations.Count.Equals(0)).ToListAsync();
            int countCollection = seeder.Count();


            for (int i = 0; i < n; i++)
            {
                var complex = seeder.Skip(rnd.Next(countCollection - 1)).Take(1).First();

                await this.plantsService.ChangeDeleteStatusComplexAsync(complex.Id, IsDeletedCondition.Deleted);

                var newComplex = new ComplexTransferModel()
                {
                    FullName = complex.FullName,
                    Name = $"ИвЛ {i}",
                    IsDeleted = false
                };

                await this.plantsService.AddComplexAsync(newComplex);

                var result = await this.context.ProductionComplexes.Where(c => c.Id.Equals(complex.Id)).FirstOrDefaultAsync();

                Assert.NotNull(result);
                Assert.IsFalse(result.IsDeleted);
            }
        }

        [Test]
        public async Task AddPlantAsync_AddNewPlant()
        {
            int n = 20;

            var rnd = new Random();
            var seeder = await this.repo.AllReadonly<ProductionComplex>().ToListAsync();
            int countCollection = seeder.Count();

            var newPlants = new List<PlantTransferModel>();

            for (int i = 0; i < n; i++)
            {
                var complex = seeder.Skip(rnd.Next(countCollection - 1)).Take(1).First();

                var newPlant = new PlantTransferModel()
                {
                    FullName = $"Тестова Инсталация {i * 10}",
                    Name = $"Тест {i * 10}",
                    ComplexId= complex.Id
                };

                await this.plantsService.AddPlantAsync(newPlant);

                newPlants.Add(newPlant);
            }

            foreach (var comlex in newPlants)
            {
                var model = await this.repo.AllReadonly<PlantInstalation>()
                    .FirstOrDefaultAsync(c => c.Name == comlex.Name && c.FullName == comlex.FullName);

                Assert.IsNotNull(model);
                Assert.AreEqual(model.FullName, comlex.FullName);
                Assert.AreEqual(model.Name, comlex.Name);
            }
        }

        [Test]
        public async Task AddPlantAsync_AddExistingPlantByName()
        {
            int n = 20;

            var rnd = new Random();
            var seeder = await this.repo.AllReadonly<ProductionComplex>().ToListAsync();
            int complecCount = seeder.Count();

            var plants = await this.repo.AllReadonly<PlantInstalation>()
                .AsNoTracking()
                .ToListAsync();

            int plantsCount = plants.Count();

            for (int i = 0; i < n; i++)
            {
                var complex = seeder.Skip(rnd.Next(complecCount - 1)).Take(1).First();
                var plant = plants.Skip(rnd.Next(plantsCount - 1)).Take(1).First();

                var newPlant = new PlantTransferModel()
                {
                    FullName = $"Тестова Инсталация {i * 10}",
                    Name = plant.Name,
                    ComplexId = complex.Id
                };

                Assert.ThrowsAsync<IdentityЕxception>(async () => { await this.plantsService.AddPlantAsync(newPlant); });
            }
        }

        [Test]
        public async Task AddPlantAsync_AddExistingPlantByFullName()
        {
            int n = 20;

            var rnd = new Random();
            var seeder = await this.repo.AllReadonly<ProductionComplex>().ToListAsync();
            int complecCount = seeder.Count;

            var plants = await this.repo.AllReadonly<PlantInstalation>()
                .AsNoTracking()
                .ToListAsync();

            int plantsCount = plants.Count;

            for (int i = 0; i < n; i++)
            {
                var complex = seeder.Skip(rnd.Next(complecCount - 1)).Take(1).First();
                var plant = plants.Skip(rnd.Next(plantsCount - 1)).Take(1).First();

                var newPlant = new PlantTransferModel()
                {
                    FullName = plant.FullName,
                    Name = $"Тест {i * 10}",
                    ComplexId = complex.Id
                };

                Assert.ThrowsAsync<IdentityЕxception>(async () => { await this.plantsService.AddPlantAsync(newPlant); });
            }
        }

        [Test]
        public async Task AddTechnologicalPositionAsync_AddNewPosition()
        {
            int n = 20;
            var rnd = new Random();

            var plants = await this.repo.AllReadonly<PlantInstalation>()
                .AsNoTracking()
                .ToListAsync();
            int plantCount = plants.Count;

            List<TechnologicalPositionTransferModel> positions = new List<TechnologicalPositionTransferModel>();

            for (int i = 0; i < n; i++)
            {
                var plant = plants.Skip(rnd.Next(plantCount) - 1).Take(1).First();
                var newPosition = new TechnologicalPositionTransferModel()
                {
                    Name = $"Test {i * 10}",
                    InstalationId = plant.Id
                };

                await this.plantsService.AddTechnologicalPositionAsync(newPosition);

                positions.Add(newPosition);
            }

            var result = await this.context.TechnologicalPositions.AsNoTracking().ToListAsync();

            foreach (var position in positions)
            {
                var target = result
                    .FirstOrDefault(tp => tp.Name.Equals(position.Name) && tp.InstalationId.Equals(position.InstalationId));

                Assert.NotNull(target);                
            }
        }

        [Test]
        public async Task AddTechnologicalPositionAsync_AddExistingPositionByName()
        {
            int n = 20;
            var rnd = new Random();

            var plants = await this.repo.AllReadonly<PlantInstalation>()
                .AsNoTracking()
                .ToListAsync();
            int plantCount = plants.Count;

            List<TechnologicalPositionTransferModel> positions = new List<TechnologicalPositionTransferModel>();
            var plant = plants.Skip(rnd.Next(plantCount) - 1).Take(1).First();

            for (int i = 0; i < n; i++)
            {                
                var newPosition = new TechnologicalPositionTransferModel()
                {
                    Name = $"Test {i * 10}",
                    InstalationId = plant.Id
                };

                await this.plantsService.AddTechnologicalPositionAsync(newPosition);

                positions.Add(newPosition);
            }

            var result = await this.context.TechnologicalPositions.AsNoTracking().ToListAsync();

            foreach (var position in positions)
            {
                Assert.ThrowsAsync<IdentityЕxception>(async () => { await this.plantsService.AddTechnologicalPositionAsync(position); });
            }
        }
    }
}
