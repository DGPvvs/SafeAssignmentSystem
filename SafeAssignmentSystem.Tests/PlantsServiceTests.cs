﻿namespace SafeAssignmentSystem.Tests
{
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Common.Exceptions;
    using SafeAssignmentSystem.Common.Exeptions;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels;
    using SafeAssignmentSystem.Core.Service;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;
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

                Thread.Sleep(50);
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
                    ComplexId = complex.Id
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

        [Test]
        public async Task ChangeDeleteStatusComplexAsync_DeletedEmptyComplex()
        {
            var newComplex = new ComplexTransferModel()
            {
                Name = "Test Complex",
                FullName = "Test FullName",
                IsDeleted = false
            };

            await this.plantsService.AddComplexAsync(newComplex);

            var compleses = await this.repo
                .AllReadonly<ProductionComplex>()
                .AsNoTracking()
                .ToListAsync();

            Guid complexId = compleses.First(c => c.FullName.Equals(newComplex.FullName)).Id;

            await this.plantsService.ChangeDeleteStatusComplexAsync(complexId, IsDeletedCondition.Deleted);

            var complex = await this.repo
                .AllReadonly<ProductionComplex>()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == complexId);

            Assert.IsNotNull(complex);
            Assert.IsTrue(complex.IsDeleted);
        }

        [Test]
        public async Task ChangeDeleteStatusComplexAsync_RecoveredEmptyComplex()
        {
            var newComplex = new ComplexTransferModel()
            {
                Name = "Test Complex",
                FullName = "Test FullName",
                IsDeleted = true
            };

            await this.plantsService.AddComplexAsync(newComplex);

            var compleses = await this.repo
                .AllReadonly<ProductionComplex>()
                .AsNoTracking()
                .ToListAsync();

            Guid complexId = compleses.First(c => c.FullName.Equals(newComplex.FullName)).Id;

            await this.plantsService.ChangeDeleteStatusComplexAsync(complexId, IsDeletedCondition.NotDeleted);

            var complex = await this.repo
                .AllReadonly<ProductionComplex>()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == complexId);

            Assert.IsNotNull(complex);
            Assert.IsFalse(complex.IsDeleted);
        }

        [Test]
        public async Task ChangeDeleteStatusComplexAsync_NotExistedEmptyComplex()
        {
            int n = 20;
            int i = 0;

            while (i < n)
            {
                Guid id = Guid.NewGuid();

                var compleses = await this.repo
                    .AllReadonly<ProductionComplex>()
                    .AsNoTracking()
                    .ToListAsync();

                var complex = compleses
                    .Where(c => c.Id.Equals(id));

                if (complex.Count().Equals(0))
                {
                    Assert.ThrowsAsync<NullReferenceException>(async () => await this.plantsService.ChangeDeleteStatusComplexAsync(id, IsDeletedCondition.NotDeleted));
                    i++;
                }
            }
        }

        [Test]
        public async Task ChangeDeleteStatusComplexAsync_HaveOnePlant()
        {
            var complex = new ComplexTransferModel()
            {
                Name = "Test",
                FullName = "Test Complex",
                IsDeleted = false
            };

            await this.plantsService.AddComplexAsync(complex);

            var compleses = await this.repo
                .AllReadonly<ProductionComplex>()
                .AsNoTracking()
                .Where(c => c.Name.Equals(complex.Name) && c.FullName.Equals(complex.FullName))
                .ToListAsync();

            var complexId = compleses.First().Id;

            var plant = new PlantTransferModel()
            {
                Name = "Test",
                FullName = "Test Plant1",
                ComplexId = complexId
            };

            await this.plantsService.AddPlantAsync(plant);

            Assert.ThrowsAsync<NotEmptyException>(async () => await this.plantsService.ChangeDeleteStatusComplexAsync(complexId, IsDeletedCondition.NotDeleted));
        }

        [Test]
        public async Task ChangeDeleteStatusComplexAsync_HaveMoreOnePlant()
        {
            var complex = new ComplexTransferModel()
            {
                Name = "Test",
                FullName = "Test Complex",
                IsDeleted = false
            };

            await this.plantsService.AddComplexAsync(complex);

            var compleses = await this.repo
                .AllReadonly<ProductionComplex>()
                .AsNoTracking()
                .Where(c => c.Name.Equals(complex.Name) && c.FullName.Equals(complex.FullName))
                .ToListAsync();

            var complexId = compleses.First().Id;

            var plant = new PlantTransferModel()
            {
                Name = "Test1",
                FullName = "Test Plant1",
                ComplexId = complexId
            };

            await this.plantsService.AddPlantAsync(plant);

            plant = new PlantTransferModel()
            {
                Name = "Test2",
                FullName = "Test Plant2",
                ComplexId = complexId
            };

            await this.plantsService.AddPlantAsync(plant);

            Assert.ThrowsAsync<NotEmptyException>(async () => await this.plantsService.ChangeDeleteStatusComplexAsync(complexId, IsDeletedCondition.NotDeleted));
        }

        [Test]
        public async Task EditComplexAsync_EditExistingComplex()
        {
            var complexes = await this.repo
                .AllReadonly<ProductionComplex>()
                .AsNoTracking()
                .ToListAsync();

            List<ComplexTransferModel> editedComplexes = new List<ComplexTransferModel>();

            foreach (var complex in complexes)
            {
                complex.Name = $"{complex.Name} Test";
                complex.FullName = $"{complex.FullName} Test";

                var editComplex = new ComplexTransferModel()
                {
                    Name = complex.Name,
                    FullName = complex.FullName,
                    Id = complex.Id
                };

                editedComplexes.Add(editComplex);

                await this.plantsService.EditComplexAsync(editComplex);
            }

            foreach (var complex in editedComplexes)
            {
                var target = await this.repo
                    .AllReadonly<ProductionComplex>()
                    .FirstOrDefaultAsync(c => c.Id.Equals(complex.Id));

                Assert.NotNull(target);
                Assert.AreEqual(target.Name, complex.Name);
                Assert.AreEqual(target.FullName, complex.FullName);
            }
        }

        [Test]
        public async Task EditComplexAsync_EditExistingComplexByNameAndFullName()
        {
            var complexes = await this.repo
                .AllReadonly<ProductionComplex>()
                .AsNoTracking()
                .ToListAsync();

            var newComplex = new ComplexTransferModel()
            {
                Name = "Test",
                FullName = "Full Test",
                IsDeleted = false
            };

            await this.plantsService.AddComplexAsync(newComplex);

            var testComplexes = await this.repo
                .AllReadonly<ProductionComplex>(c => c.FullName.Equals(newComplex.FullName) && c.Name.Equals(newComplex.Name))
                .AsNoTracking()
                .ToListAsync();

            var testComplex = testComplexes.First();

            foreach (var complex in complexes)
            {
                var editComplex = new ComplexTransferModel()
                {
                    Name = complex.Name,
                    FullName = complex.FullName,
                    IsDeleted = testComplex.IsDeleted,
                    Id = testComplex.Id
                };

                Assert.ThrowsAsync<IdentityЕxception>(async () => { await this.plantsService.EditComplexAsync(editComplex); });
            }
        }

        [Test]
        public async Task EditComplexAsync_EditExistingComplexByNameAndFullNameIsDeleted()
        {
            int n = 20;

            for (int i = 0; i < n; i++)
            {
                var newComplex = new ComplexTransferModel()
                {
                    Name = $"Test{i}",
                    FullName = $"Full Test{i}",
                    IsDeleted = true
                };

                await this.plantsService.AddComplexAsync(newComplex);
            }

            var testComplex = new ComplexTransferModel()
            {
                Name = $"Test",
                FullName = $"Full Test",
                IsDeleted = true
            };

            await this.plantsService.AddComplexAsync(testComplex);

            var complexes = await this.repo
                .AllReadonly<ProductionComplex>()
                .AsNoTracking()
                .Where(c => c.IsDeleted)
                .ToListAsync();

            var testComplexes = await this.repo
                .AllReadonly<ProductionComplex>(c => c.FullName.Equals(testComplex.FullName) && c.Name.Equals(testComplex.Name))
                .AsNoTracking()
                .ToListAsync();

            var target = testComplexes.First();

            foreach (var complex in complexes)
            {
                await this.plantsService.ChangeDeleteStatusComplexAsync(complex.Id, IsDeletedCondition.Deleted);

                var editComplex = new ComplexTransferModel()
                {
                    Name = complex.Name,
                    FullName = complex.FullName,
                    IsDeleted = testComplex.IsDeleted,
                    Id = testComplex.Id
                };

                Assert.ThrowsAsync<IdentityЕxception>(async () => { await this.plantsService.EditComplexAsync(editComplex); });
            }
        }

        [Test]
        public async Task EditPlantAsync_EditCorect()
        {
            var rnd = new Random();
            var complexes = await this.repo.AllReadonly<ProductionComplex>().AsNoTracking().ToListAsync();

            var complex = complexes.Skip(rnd.Next(complexes.Count) - 1).Take(1).First();

            var newPlant = new PlantTransferModel()
            {
                Name = "Test",
                FullName = "Test Instalation",
                ComplexId = complex.Id,
                ComplexName = complex.Name,
                FullComplexName = complex.FullName
            };

            await this.plantsService.AddPlantAsync(newPlant);

            var editedPlants = await this.repo
                .AllReadonly<PlantInstalation>()
                .AsNoTracking()
                .Where(p => p.Name.Equals(newPlant.Name)
                    && p.FullName.Equals(newPlant.FullName))
                .ToListAsync();

            var editedPlant = editedPlants.First();

            var target = new PlantTransferModel()
            {
                Name = $"{editedPlant.Name}Edited",
                FullName = $"{editedPlant.FullName}Edited",
                ComplexId = editedPlant.ComplexId,
                Id = editedPlant.Id
            };

            await this.plantsService.EditPlantAsync(target);

            var result = await this.repo.GetByIdAsync<PlantInstalation>(target.Id);

            Assert.NotNull(result);
            Assert.AreEqual(result.Name, target.Name);
            Assert.AreEqual(result.FullName, target.FullName);
            Assert.AreEqual(result.ComplexId, target.ComplexId);
        }

        [Test]
        public async Task EditPlantAsync_EditIfPlantExist()
        {
            var rnd = new Random();
            var complexes = await this.repo.AllReadonly<ProductionComplex>().AsNoTracking().ToListAsync();

            var complex = complexes.Skip(rnd.Next(complexes.Count) - 1).Take(1).First();

            var newPlant = new PlantTransferModel()
            {
                Name = "Test",
                FullName = "Test Instalation",
                ComplexId = complex.Id,
                ComplexName = complex.Name,
                FullComplexName = complex.FullName
            };

            var allPlants = await this.repo.AllReadonly<PlantInstalation>().AsNoTracking().ToListAsync();

            await this.plantsService.AddPlantAsync(newPlant);

            var editedPlants = await this.repo
                .AllReadonly<PlantInstalation>()
                .AsNoTracking()
                .Where(p => p.Name.Equals(newPlant.Name)
                && p.FullName.Equals(newPlant.FullName))
                .ToListAsync();

            var editedPlant = editedPlants.First();

            foreach (var plant in allPlants)
            {
                var target = new PlantTransferModel()
                {
                    Name = plant.Name,
                    FullName = plant.FullName,
                    ComplexId = editedPlant.ComplexId,
                    Id = editedPlant.Id
                };

                Assert.ThrowsAsync<IdentityЕxception>(async () => await this.plantsService.EditPlantAsync(target));
            }
        }

        [Test]
        public async Task EditTechnologicalPositionAsync_EditPositionCorect()
        {
            var rnd = new Random();

            var allPlants = await this.repo.AllReadonly<PlantInstalation>().AsNoTracking().ToListAsync();
            var plant = allPlants.Skip(rnd.Next(allPlants.Count) - 1).Take(1).First();

            var newPosition = new TechnologicalPositionTransferModel()
            {
                Name = "Test Position",
                InstalationId = plant.Id,
                InstalationName = plant.Name
            };

            await this.plantsService.AddTechnologicalPositionAsync(newPosition);

            var editPositions = await this.repo.AllReadonly<TechnologicalPosition>()
                .AsNoTracking()
                .Where(tp => tp.Name.Equals(newPosition.Name)
                    && tp.InstalationId.Equals(newPosition.InstalationId)
                    && tp.Instalation.Name.Equals(newPosition.InstalationName))
                .ToListAsync();

            var editPosition = editPositions.First();

            var target = new TechnologicalPositionTransferModel()
            {
                Name = $"{editPosition.Name}Edited",
                Id = editPosition.Id,
                InstalationId = editPosition.InstalationId,
            };

            await this.plantsService.EditTechnologicalPositionAsync(target);

            var result = await this.repo.GetByIdAsync<TechnologicalPosition>(target.Id);

            Assert.NotNull(result);
            Assert.AreEqual(result.Name, target.Name);
        }

        [Test]
        public async Task EditTechnologicalPositionAsync_EditPositionIfPositionExist()
        {
            var rnd = new Random();

            var plants = await this.repo
                .AllReadonly<PlantInstalation>()
                .Where(pi => pi.Name.Equals("ККр"))
                .AsNoTracking()
                .ToListAsync();

            var plant = plants.First();

            var allPosition = await this.repo.AllReadonly<TechnologicalPosition>()
                .AsNoTracking()
                .Where(tp => tp.InstalationId.Equals(plant.Id))
                .ToListAsync();

            foreach (var position in allPosition)
            {
                var newPosition = new TechnologicalPositionTransferModel()
                {
                    Name = position.Name,
                    InstalationId = position.InstalationId
                };

                Assert.ThrowsAsync<IdentityЕxception>(async () => await this.plantsService.EditTechnologicalPositionAsync(newPosition));
            }
        }

        [Test]
        public async Task GetAllComplexAsync_NotDeleted()
        {
            var allComplex = await this.repo
                .AllReadonly<ProductionComplex>()
                .AsNoTracking()
                .Where(c => !c.IsDeleted)
                .ToListAsync();

            int testCoint = allComplex.Count();

            var result = await this.plantsService.GetAllComplexAsync(IsDeletedCondition.NotDeleted);

            int resultCount = result.Count();

            Assert.AreEqual(testCoint, resultCount);
        }

        [Test]
        public async Task GetAllComplexAsync_Deleted()
        {
            var allComplex = await this.repo
                .AllReadonly<ProductionComplex>()
                .AsNoTracking()
                .Where(c => c.IsDeleted)
                .ToListAsync();

            int testCoint = allComplex.Count();

            var result = await this.plantsService.GetAllComplexAsync(IsDeletedCondition.Deleted);

            int resultCount = result.Count();

            Assert.AreEqual(testCoint, resultCount);
        }

        [Test]
        public async Task GetTechnologicalPositionByIdAsync_Count()
        {
            var allPosition = await this.repo.AllReadonly<TechnologicalPosition>()
                .AsNoTracking()
                .ToListAsync();

            foreach (var position in allPosition)
            {
                var test = await this.plantsService.GetTechnologicalPositionByIdAsync(position.Id);
                var plant = await this.repo.GetByIdAsync<PlantInstalation>(test.InstalationId);
                var complex = await this.repo.GetByIdAsync<ProductionComplex>(plant.ComplexId);

                Assert.IsNotNull(test);
                Assert.AreEqual(test.Name, position.Name);
                Assert.AreEqual(test.InstalationName, plant.Name);
                Assert.AreEqual(test.ComplexName, complex.FullName);
            }
        }

        [Test]
        public async Task GetComplexByIdAsync()
        {
            var allComplexes = await this.repo
                .AllReadonly<ProductionComplex>()
                .AsNoTracking()
                .ToListAsync();

            foreach (var complex in allComplexes)
            {
                var target = await this.plantsService.GetComplexByIdAsync(complex.Id);

                Assert.NotNull(target);
                Assert.AreEqual(target.Name, complex.Name);
                Assert.AreEqual(target.FullName, complex.FullName);
            }
        }

        [Test]
        public async Task GetPlantByIdAsync()
        {
            var allPlants = await this.repo
                .AllReadonly<PlantInstalation>()
                .AsNoTracking()
                .ToListAsync();

            foreach (var plant in allPlants)
            {
                var complex = await this.repo.GetByIdAsync<ProductionComplex>(plant.ComplexId);
                var target = await this.plantsService.GetPlantByIdAsync(plant.Id);

                Assert.NotNull(target);
                Assert.AreEqual(target.Name, plant.Name);
                Assert.AreEqual(target.FullName, plant.FullName);
                Assert.AreEqual(target.ComplexName, complex.Name);
                Assert.AreEqual(target.FullComplexName, complex.FullName);
            }
        }

        [Test]
        public async Task GetAllPositionInPlantByIdAsync()
        {
            var plants = await this.repo
                .AllReadonly<PlantInstalation>()
                .AsNoTracking()
                .ToListAsync();

            foreach (var plant in plants)
            {
                var targetPositions = await this.plantsService.GetAllPositionInPlantByIdAsync(plant.Id);

                var positions = await this.repo
                    .AllReadonly<TechnologicalPosition>()
                    .AsNoTracking()
                    .Where(tp => tp.InstalationId.Equals(plant.Id))
                    .ToListAsync();

                Assert.AreEqual(targetPositions.Count(), positions.Count);
            }
        }

        [Test]
        public async Task GetPlantByPositionId()
        {
            var allPositions = await this.repo
                .AllReadonly<TechnologicalPosition>()
                .AsNoTracking()
                .ToListAsync();

            foreach (var position in allPositions)
            {
                var plant = await this.repo
                    .GetByIdAsync<PlantInstalation>(position.InstalationId);
                var comlex = await this.repo
                    .GetByIdAsync<ProductionComplex>(plant.ComplexId);

                var target = await this.plantsService.GetPlantByPositionId(position.Id);

                Assert.NotNull(target);
                Assert.AreEqual(target.Name, plant.Name);
                Assert.AreEqual(target.FullName, plant.FullName);
                Assert.AreEqual(target.ComplexName, comlex.FullName);
            }
        }

        [Test]
        public async Task GetPlantByPositionId_ThrowsException()
        {
            Guid id = Guid.Empty;

            Assert.ThrowsAsync<TechnologicalPositionException>(async () => { await this.plantsService.GetPlantByPositionId(id); });
        }
    }
}
