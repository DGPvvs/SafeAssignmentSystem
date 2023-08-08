namespace SafeAssignmentSystem.Tests
{
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Common.Enums;
    using SafeAssignmentSystem.Common.Exceptions;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels;
    using SafeAssignmentSystem.Core.Service;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.SafeAssignmentDocumentModels;
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
                var safeAssignment = await this.CreateTestSafeAssignment(position);
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
            int n = 20;
            var rnd = new Random();

            var allPositions = await this.repo
                .AllReadonly<TechnologicalPosition>()
                .AsNoTracking()
                .ToListAsync();

            for (int i = 0; i < n; i++)
            {
                var position = allPositions.Skip(rnd.Next(allPositions.Count) - 1).Take(1).First();

                var safeAssignment = await this.CreateTestSafeAssignment(position);

                await this.safeAssignmentService.CreateSafeAssignmentAsync(safeAssignment);

                var targets = await this.repo
                    .AllReadonly<SafeAssignmentDocument>()
                    .AsNoTracking()
                    .Where(sa => sa.Number.Equals(safeAssignment.Number))
                    .ToListAsync();

                var target = targets.FirstOrDefault();

                Assert.NotNull(target);
                Assert.AreEqual(target.Status, safeAssignment.Status);
                Assert.AreEqual(target.TechnologicalPositionId, safeAssignment.TechnologicalPositionId);
                Assert.AreEqual(target.PersonRequestedOpeningOrderId, safeAssignment.PersonRequestedOpeningOrderId);
            }
        }

        [Test]
        public async Task OpeningSafeAssignmentAsync_Corect()
        {
            int n = 20;
            var rnd = new Random();

            var allPositions = await this.repo
                .AllReadonly<TechnologicalPosition>()
                .AsNoTracking()
                .ToListAsync();

            var testedList = new List<string>();
            var testedQueue = new Queue<Guid>();

            for (int i = 0; i < n; i++)
            {
                var position = allPositions.Skip(rnd.Next(allPositions.Count) - 1).Take(1).First();
                var safeAssignment = await this.CreateTestSafeAssignment(position);

                await this.safeAssignmentService.CreateSafeAssignmentAsync(safeAssignment);

                var targets = await this.repo
                    .AllReadonly<SafeAssignmentDocument>()
                    .AsNoTracking()
                    .Where(sa => sa.Number.Equals(safeAssignment.Number))
                    .ToListAsync();

                var target = targets.FirstOrDefault();

                testedList.Add(target.Number);
            }

            foreach (var safeAssignmentNum in testedList)
            {
                var targets = await this.repo
                    .AllReadonly<SafeAssignmentDocument>()
                    .AsNoTracking()
                    .Where(sa => sa.Number.Equals(safeAssignmentNum))
                    .ToListAsync();

                var target = targets.FirstOrDefault();

                var status = await this.safeAssignmentService.OpeningSafeAssignmentAsync(target.Id, this.electricianId);

                Assert.IsTrue(status.Success);
                testedQueue.Enqueue(target.Id);
            }

            while (testedQueue.Count > 0)
            {
                var id = testedQueue.Dequeue();

                var target = await this.repo
                    .GetByIdAsync<SafeAssignmentDocument>(id);

                var safeAssignment = await this.safeAssignmentService.GetSafeAssignmentByIdAsync(id);

                Assert.NotNull(target);
                Assert.NotNull(safeAssignment);
                Assert.AreEqual(target.Number, safeAssignment.Number);
                Assert.AreEqual(target.TechnologicalPositionId, safeAssignment.TechnologicalPositionId);
                Assert.AreEqual(target.PersonRequestedOpeningOrderId, safeAssignment.PersonRequestedOpeningOrderId);
                Assert.AreEqual(target.ЕlectricianOpeningOrderId, safeAssignment.ЕlectricianOpeningOrderId);
                Assert.AreEqual(target.Status, StatusFlagsEnum.Opening);
            }
        }

        [Test]
        public async Task ClosingSafeAssignmentAsync_Corect()
        {
            int n = 20;
            var rnd = new Random();

            var allPositions = await this.repo
                .AllReadonly<TechnologicalPosition>()
                .AsNoTracking()
                .ToListAsync();

            var testedList = new List<string>();
            var testedQueue = new Queue<Guid>();

            for (int i = 0; i < n; i++)
            {
                var position = allPositions.Skip(rnd.Next(allPositions.Count) - 1).Take(1).First();
                var safeAssignment = await this.OpeningTestSafeAssignmentAsync(position);

                await this.SetTestSafeAssignmentInBase(safeAssignment);

                var targets = await this.repo
                    .AllReadonly<SafeAssignmentDocument>()
                    .AsNoTracking()
                    .Where(sa => sa.Number.Equals(safeAssignment.Number))
                    .ToListAsync();

                var target = targets.FirstOrDefault();

                testedList.Add(target.Number);
            }

            foreach (var safeAssignmentNum in testedList)
            {
                var targets = await this.repo
                    .AllReadonly<SafeAssignmentDocument>()
                    .AsNoTracking()
                    .Where(sa => sa.Number.Equals(safeAssignmentNum))
                    .ToListAsync();

                var target = targets.FirstOrDefault();

                var status = await this.safeAssignmentService.ClosingSafeAssignmentAsync(target.Id, this.electricianId);

                Assert.IsTrue(status.Success);
                testedQueue.Enqueue(target.Id);
            }

            while (testedQueue.Count > 0)
            {
                var id = testedQueue.Dequeue();

                var target = await this.repo
                    .GetByIdAsync<SafeAssignmentDocument>(id);

                var safeAssignment = await this.safeAssignmentService.GetSafeAssignmentByIdAsync(id);

                Assert.NotNull(target);
                Assert.NotNull(safeAssignment);
                Assert.AreEqual(target.Number, safeAssignment.Number);
                Assert.AreEqual(target.TechnologicalPositionId, safeAssignment.TechnologicalPositionId);
                Assert.AreEqual(target.PersonRequestedOpeningOrderId, safeAssignment.PersonRequestedOpeningOrderId);
                Assert.AreEqual(target.ЕlectricianOpeningOrderId, safeAssignment.ЕlectricianOpeningOrderId);
                Assert.AreEqual(target.ЕlectricianClosingOrderId, safeAssignment.ЕlectricianClosingOrderId);
                Assert.AreEqual(target.Status, StatusFlagsEnum.Closing);
            }
        }

        [Test]
        public async Task ClosingSafeAssignmentAsync_Fail()
        {            
            int n = 20;
            int i = 0;

            while (i < n)            
            {
                Guid testId = Guid.NewGuid();

                var testSafeAssignment = await this.repo.GetByIdAsync<SafeAssignmentDocument>(testId);

                if (testSafeAssignment is null)
                {                    
                    var status = await this.safeAssignmentService.ClosingSafeAssignmentAsync(testId, this.electricianId);
                    Assert.IsFalse(status.Success);
                    i++;
                }
            }
        }

        [Test]
        public async Task GetSafeAssignmentByIdAsync_ThrowException()
        {
            int n = 20;

            for (int i = 0; i < n; i++)
            {
                Guid safeAssignmentId = Guid.NewGuid();

                var test = await this.repo
                    .AllReadonly<SafeAssignmentDocument>()
                    .AsNoTracking()
                    .FirstOrDefaultAsync<SafeAssignmentDocument>(sa => sa.Id.Equals(safeAssignmentId));
                if (test is null)
                {
                    Assert.ThrowsAsync<SafeAssignmentNotExistException>(async () => await this.safeAssignmentService.GetSafeAssignmentByIdAsync(safeAssignmentId));
                }
            }
        }

        [Test]
        public async Task RequestedSafeAssignmentAsync_Corect()
        {
            int n = 20;
            var rnd = new Random();

            var allPositions = await this.repo
                .AllReadonly<TechnologicalPosition>()
                .AsNoTracking()
                .ToListAsync();

            var rndCountPerPosition = new Dictionary<Guid, int>();
            var testSafeAssignment = new List<Guid>();

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
                    var safeAssignment = await this.ClosingTestSafeAssignmentAsync(position);

                    await this.SetTestSafeAssignmentInBase(safeAssignment);

                    var targets = await this.repo
                    .AllReadonly<SafeAssignmentDocument>()
                    .AsNoTracking()
                    .Where(sa => sa.Number.Equals(safeAssignment.Number))
                    .ToListAsync();

                    var targetId = targets.FirstOrDefault()!.Id;

                    testSafeAssignment.Add(targetId);
                }

                var status = await this.safeAssignmentService.RequestedSafeAssignmentAsync(this.operatorId, positionKvP.Key);

                Assert.True(status.Success);
            }

            foreach (var safeAssignmentId in testSafeAssignment)
            {
                var target = await this.safeAssignmentService.GetSafeAssignmentByIdAsync(safeAssignmentId);
                rndCountPerPosition[target.TechnologicalPositionId]--;
            }

            foreach (var positionKvP in rndCountPerPosition)
            {
                Assert.AreEqual(positionKvP.Value, 0);
            }
        }

        [Test]
        public async Task AppliedSafeAssignmentAsync_WhitStatusRequired_Corect()
        {
            int n = 20;
            var rnd = new Random();

            var allPositions = await this.repo
                .AllReadonly<TechnologicalPosition>()
                .AsNoTracking()
                .ToListAsync();

            var rndCountPerPosition = new Dictionary<Guid, int>();
            var testSafeAssignment = new List<Guid>();

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
                    var safeAssignment = await this.RequiredTestSafeAssignmentAsync(position);

                    await this.SetTestSafeAssignmentInBase(safeAssignment);

                    var targets = await this.repo
                    .AllReadonly<SafeAssignmentDocument>()
                    .AsNoTracking()
                    .Where(sa => sa.Number.Equals(safeAssignment.Number))
                    .ToListAsync();

                    var targetId = targets.FirstOrDefault()!.Id;

                    testSafeAssignment.Add(targetId);
                }

                var status = await this.safeAssignmentService.AppliedSafeAssignmentAsync(this.operatorId, positionKvP.Key);

                Assert.True(status.Success);
            }

            foreach (var safeAssignmentId in testSafeAssignment)
            {
                var target = await this.safeAssignmentService.GetSafeAssignmentByIdAsync(safeAssignmentId);
                rndCountPerPosition[target.TechnologicalPositionId]--;
            }

            foreach (var positionKvP in rndCountPerPosition)
            {
                Assert.AreEqual(positionKvP.Value, 0);
            }
        }

        [Test]
        public async Task AppliedSafeAssignmentAsync_WhitStatusClosing_Corect()
        {
            int n = 20;
            var rnd = new Random();

            var allPositions = await this.repo
                .AllReadonly<TechnologicalPosition>()
                .AsNoTracking()
                .ToListAsync();

            var rndCountPerPosition = new Dictionary<Guid, int>();
            var testSafeAssignment = new List<Guid>();

            foreach (var position in allPositions)
            {
                int count = rnd.Next(1, n + 1);
                rndCountPerPosition[position.Id] = count;
            }

            foreach (var positionKvP in rndCountPerPosition)
            {
                var position = await this.repo
                    .GetByIdAsync<TechnologicalPosition>(positionKvP.Key);

                var safeAssignment = await this.RequiredTestSafeAssignmentAsync(position);

                await this.SetTestSafeAssignmentInBase(safeAssignment);

                var targets = await this.repo
                .AllReadonly<SafeAssignmentDocument>()
                .AsNoTracking()
                .Where(sa => sa.Number.Equals(safeAssignment.Number))
                .ToListAsync();

                var targetId = targets.FirstOrDefault()!.Id;

                testSafeAssignment.Add(targetId);

                for (int i = 1; i < positionKvP.Value; i++)
                {
                    safeAssignment = await this.ClosingTestSafeAssignmentAsync(position);

                    await this.SetTestSafeAssignmentInBase(safeAssignment);

                    targets = await this.repo
                    .AllReadonly<SafeAssignmentDocument>()
                    .AsNoTracking()
                    .Where(sa => sa.Number.Equals(safeAssignment.Number))
                    .ToListAsync();

                    targetId = targets.FirstOrDefault()!.Id;

                    testSafeAssignment.Add(targetId);
                }

                var status = await this.safeAssignmentService.AppliedSafeAssignmentAsync(this.operatorId, positionKvP.Key);

                Assert.True(status.Success);
            }

            foreach (var safeAssignmentId in testSafeAssignment)
            {
                var target = await this.safeAssignmentService.GetSafeAssignmentByIdAsync(safeAssignmentId);
                rndCountPerPosition[target.TechnologicalPositionId]--;
            }

            foreach (var positionKvP in rndCountPerPosition)
            {
                Assert.AreEqual(positionKvP.Value, 0);
            }
        }


        private async Task SetTestSafeAssignmentInBase(SafeAssignmentTransferModel testModel)
        {
            var newSafeAssignment = new SafeAssignmentDocument()
            {
                Number = testModel.Number,
                TechnologicalPositionId = testModel.TechnologicalPositionId,

                PersonRequestedOpeningOrderId = testModel.PersonRequestedOpeningOrderId,
                ЕlectricianOpeningOrderId = testModel.ЕlectricianOpeningOrderId,

                ЕlectricianClosingOrderId = testModel.ЕlectricianClosingOrderId,
                PersonRequestedVoltageSupplyId = testModel.PersonRequestedVoltageSupplyId,
                ElectricianAppliedVoltageId = testModel.ElectricianAppliedVoltageId,
                Status = testModel.Status
            };

            if (testModel.OpeningDate.Equals(null) || testModel.OpeningTime.Equals(null))
            {
                newSafeAssignment.OpeningDate = null;
            }
            else
            {
                newSafeAssignment.OpeningDate = new DateTime(testModel.OpeningDate.Value.Year, testModel.OpeningDate.Value.Month, testModel.OpeningDate.Value.Day, testModel.OpeningTime.Value.Hour, testModel.OpeningTime.Value.Minute, 0);
            }

            if (testModel.ClosingDate.Equals(null) || testModel.ClosingTime.Equals(null))
            {
                newSafeAssignment.ClosingDate = null;
            }
            else
            {
                newSafeAssignment.ClosingDate = new DateTime(testModel.ClosingDate.Value.Year, testModel.ClosingDate.Value.Month, testModel.ClosingDate.Value.Day, testModel.ClosingTime.Value.Hour, testModel.ClosingTime.Value.Minute, 0);
            }

            await this.repo.AddAsync(newSafeAssignment);
            await this.repo.SaveChangesAsync();
        }

        private async Task<SafeAssignmentTransferModel> CreateTestSafeAssignment(TechnologicalPosition position)
        {
            var rnd = new Random();
            var plant = await this.repo
                .GetByIdAsync<PlantInstalation>(position.InstalationId);
            var complex = await this.repo
                .GetByIdAsync<ProductionComplex>(plant.ComplexId);

            string number = $"{rnd.Next(10)}{rnd.Next(10)}{rnd.Next(10)}{rnd.Next(10)}";


            var newSafeAssignment = new SafeAssignmentTransferModel()
            {
                Number = string.Format(SafeAssignmentDocumentConstants.Format_Number, complex.Name, plant.Name, number, DateTime.Now.ToString("o")),
                TechnologicalPositionId = position.Id,
                PersonRequestedOpeningOrderId = this.operatorId,
                Status = StatusFlagsEnum.Created
            };

            Thread.Sleep(10);
            return newSafeAssignment;
        }

        private async Task<SafeAssignmentTransferModel> OpeningTestSafeAssignmentAsync(TechnologicalPosition position)
        {
            var newSafeAssignment = await this.CreateTestSafeAssignment(position);
            var time = DateTime.Now;
            newSafeAssignment.ЕlectricianOpeningOrderId = this.electricianId;
            newSafeAssignment.OpeningDate = new DateOnly(time.Year, time.Month, time.Day);
            newSafeAssignment.OpeningTime = new TimeOnly(time.Hour, time.Minute);
            newSafeAssignment.Status = StatusFlagsEnum.Opening;

            return newSafeAssignment;
        }

        private async Task<SafeAssignmentTransferModel> ClosingTestSafeAssignmentAsync(TechnologicalPosition position)
        {
            var newSafeAssignment = await this.OpeningTestSafeAssignmentAsync(position);
            var time = DateTime.Now;
            newSafeAssignment.ЕlectricianClosingOrderId = this.electricianId;
            newSafeAssignment.ClosingDate = new DateOnly(time.Year, time.Month, time.Day);
            newSafeAssignment.ClosingTime = new TimeOnly(time.Hour, time.Minute);
            newSafeAssignment.Status = StatusFlagsEnum.Closing;

            return newSafeAssignment;
        }

        private async Task<SafeAssignmentTransferModel> RequiredTestSafeAssignmentAsync(TechnologicalPosition position)
        {
            var newSafeAssignment = await this.ClosingTestSafeAssignmentAsync(position);            

            newSafeAssignment.ElectricianAppliedVoltageId = this.electricianId;
            newSafeAssignment.Status = StatusFlagsEnum.Required;

            return newSafeAssignment;
        }
    }
}
