namespace SafeAssignmentSystem.Tests
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualStudio.CodeCoverage;
    using SafeAssignmentSystem.Common.Exeptions;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.IO;
    using SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels;
    using SafeAssignmentSystem.Core.Service;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.StaffsModels;
    using SafeAssignmentSystem.Tests.UnitTests;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [TestFixture]
    public class WorkingRotationServiceTest : UnitTestsBase
    {
        private IWorkingRotationService workingRotationService;

        [SetUp]
        public void Setup()
        {
            this.reader = new LoadWorkingRotationFromFile();
            this.workingRotationService = new WorkingRotationService(this.userManager, this.repo, new LoadWorkingRotationFromFile());
        }

        [Test]
        public async Task AddShiftAsync_AddNewShift()
        {
            int n = 20;

            var rnd = new Random();

            var newShiftList = new List<ShiftTransferModel>();

            for (int i = 0; i < n; i++)
            {
                var newShift = new ShiftTransferModel()
                {
                    ShiftName = $"Смяна {i}",
                    Start = new TimeOnly(rnd.Next(0, 23), rnd.Next(0, 59)),
                    End = new TimeOnly(rnd.Next(0, 23), rnd.Next(0, 59))
                };

                await this.workingRotationService.AddShiftAsync(newShift);

                newShiftList.Add(newShift);
            }

            foreach (var shift in newShiftList)
            {
                var model = await this.repo.AllReadonly<WorkingShift>()
                    .FirstOrDefaultAsync(sh => sh.ShiftName == shift.ShiftName);

                var startTime = new DateTime(1, 1, 1) + shift.Start.ToTimeSpan();
                var endTime = new DateTime(1, 1, 1) + shift.End.ToTimeSpan();

                if (shift.Start >= shift.End)
                {
                    endTime = new DateTime(1, 1, 2) + shift.End.ToTimeSpan();
                }

                Assert.IsNotNull(model);
                Assert.AreEqual(model.ShiftName, shift.ShiftName);
                Assert.AreEqual(model.StartTime, startTime);
                Assert.AreEqual(model.EndTime, endTime);
            }
        }

        [Test]
        public async Task AddShiftAsync_AddExistingShiftByName()
        {
            int n = 20;
            var rnd = new Random();
            var newShiftList = new List<ShiftTransferModel>();

            for (int i = 0; i < n; i++)
            {
                var newShift = new ShiftTransferModel()
                {
                    ShiftName = $"Смяна {i}",
                    Start = new TimeOnly(rnd.Next(0, 23), rnd.Next(0, 59)),
                    End = new TimeOnly(rnd.Next(0, 23), rnd.Next(0, 59))
                };

                await this.workingRotationService.AddShiftAsync(newShift);

                newShiftList.Add(newShift);
            }

            foreach (var Shift in newShiftList)
            {
                var newShift = new ShiftTransferModel()
                {
                    ShiftName = Shift.ShiftName
                };
                Assert.ThrowsAsync<IdentityЕxception>(async () => { await this.workingRotationService.AddShiftAsync(newShift); });
            }
        }

        [Test]
        public async Task EditShiftAsync_EditExistingShift()
        {
            var rnd = new Random();

            var shifts = await this.repo
                .AllReadonly<WorkingShift>()
                .AsNoTracking()
                .ToListAsync();

            List<ShiftTransferModel> editedShifts = new List<ShiftTransferModel>();

            foreach (var shift in shifts)
            {
                var start = new TimeOnly(rnd.Next(0, 23), rnd.Next(0, 59));
                var end = new TimeOnly(rnd.Next(0, 23), rnd.Next(0, 59));

                var editShift = new ShiftTransferModel()
                {
                    ShiftName = shift.ShiftName,
                    Start = start,
                    End = end,
                    Id = shift.Id
                };

                editedShifts.Add(editShift);

                await this.workingRotationService.EditShiftAsync(editShift);
            }

            foreach (var shift in editedShifts)
            {
                var target = await this.repo.GetByIdAsync<WorkingShift>(shift.Id);

                var startTime = new DateTime(1, 1, 1) + shift.Start.ToTimeSpan();
                var endTime = new DateTime(1, 1, 1) + shift.End.ToTimeSpan();

                if (startTime >= endTime)
                {
                    endTime = new DateTime(1, 1, 2) + shift.End.ToTimeSpan();
                }

                Assert.NotNull(target);
                Assert.AreEqual(target.ShiftName, shift.ShiftName);
                Assert.AreEqual(target.StartTime, startTime);
                Assert.AreEqual(target.EndTime, endTime);
            }
        }

        [Test]
        public async Task EditShiftAsync_EditNotExistingShift()
        {
            var editShift = new ShiftTransferModel()
            {
                Id = Guid.Empty
            };

            Assert.ThrowsAsync<NullReferenceException>(async () => await this.workingRotationService.EditShiftAsync(editShift));
        }

        [Test]
        public async Task GetAllShiftAsync_Corect()
        {
            int n = 20;

            var rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                var newShift = new ShiftTransferModel()
                {
                    ShiftName = $"Смяна {i}",
                    Start = new TimeOnly(rnd.Next(0, 23), rnd.Next(0, 59)),
                    End = new TimeOnly(rnd.Next(0, 23), rnd.Next(0, 59))
                };

                await this.workingRotationService.AddShiftAsync(newShift);
            }

            var reper = this.repo.AllReadonly<WorkingShift>();//.ToListAsync();

            var target = await this.workingRotationService.GetAllShiftAsync();

            Assert.AreEqual(target.Count(), reper.Count());
        }

        [Test]
        public async Task GetShiftByIdAsync_Corect()
        {
            int n = 20;

            var rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                var newShift = new ShiftTransferModel()
                {
                    ShiftName = $"Смяна {i}",
                    Start = new TimeOnly(rnd.Next(0, 23), rnd.Next(0, 59)),
                    End = new TimeOnly(rnd.Next(0, 23), rnd.Next(0, 59))
                };

                await this.workingRotationService.AddShiftAsync(newShift);
            }

            var targets = await this.workingRotationService.GetAllShiftAsync();

            for (int i = 0; i < n; i++)
            {
                var reper = targets.Skip(rnd.Next(targets.Count()) - 1).Take(1).First();

                var target = await this.workingRotationService.GetShiftByIdAsync(reper.Id);

                Assert.NotNull(target);
                Assert.AreEqual(target.ShiftName, reper.ShiftName);
                Assert.AreEqual(target.Start, reper.Start);
                Assert.AreEqual(target.End, reper.End);
            }
        }

        [Test]
        public async Task GetShiftByIdAsync_ThrowNullReferenceException()
        {
            Assert.ThrowsAsync<NullReferenceException>(async () => await this.workingRotationService.GetShiftByIdAsync(Guid.Empty));
        }
    }
}
