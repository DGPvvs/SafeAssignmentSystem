namespace SafeAssignmentSystem.Tests.UnitTests
{
    using Microsoft.AspNetCore.Identity;
    using Moq;
    using OfficeOpenXml;
    using SafeAssignmentSystem.Common.Enums;
    using SafeAssignmentSystem.Common.IO.Contracts;
    using SafeAssignmentSystem.Core.Data;
    using SafeAssignmentSystem.Core.Models.TransferModels.SafeAssignmentTransferModels;
    using SafeAssignmentSystem.DataBase.Data.Common;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.SafeAssignmentDocumentModels;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.StaffsModels;
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;
    using SafeAssignmentSystem.Tests.Mocks;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using static SafeAssignmentSystem.Common.ModelsConstants.DataModelsConstants;

    public class UnitTestsBase
    {
        protected SafeAssignmentDbContext context;
        protected IRepository repo;
        protected UserManager<ApplicationUser> userManager;
        protected IReader? reader;

        protected Guid electricianId;
        protected Guid operatorId;

        [SetUp]
        public void SetUpBase()
        {
            this.context = DataBaseMock.Instance;
            this.repo = new Repository(this.context);
            this.userManager = MockUserManager<ApplicationUser>(new SeedsData().SeedUsers().ToList()).Object;
            this.SeedDataBase();
        }

        private void SeedDataBase()
        {
            this.context.PlantInstalations.AddRange(new SeedsData().SeedPlantInstalation());
            this.context.ProductionComplexes.AddRange(new SeedsData().SeedComplex());
            this.context.TechnologicalPositions.AddRange(new SeedsData().SeedTechnologicalPosition());
            this.context.WorkingShifts.AddRange(new SeedsData().SeedWorkingShift());
            this.context.ApplicationUserPlantInstalations.AddRange(new SeedsData().SeedApplicationUserPlantInstalation());
            this.context.ChangedsSchedules.AddRange(this.CreateChangedSchedule());

            this.context.Roles.AddRange(this.CreateRoles());
            this.context.Users.AddRange(this.CreateUsers());
            this.context.UserRoles.AddRange(this.CreateUsersRole());
            this.context.SaveChanges();
        }

        private static Mock<UserManager<TUser>> MockUserManager<TUser>(List<TUser> ls) where TUser : class
        {
            var store = new Mock<IUserStore<TUser>>();
            var mgr = new Mock<UserManager<TUser>>(store.Object, null, null, null, null, null, null, null, null);
            mgr.Object.UserValidators.Add(new UserValidator<TUser>());
            mgr.Object.PasswordValidators.Add(new PasswordValidator<TUser>());

            mgr.Setup(x => x.DeleteAsync(It.IsAny<TUser>())).ReturnsAsync(IdentityResult.Success);
            mgr.Setup(x => x.CreateAsync(It.IsAny<TUser>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Success).Callback<TUser, string>((x, y) => ls.Add(x));
            mgr.Setup(x => x.UpdateAsync(It.IsAny<TUser>())).ReturnsAsync(IdentityResult.Success);            

            return mgr;
        }

        private IEnumerable<IdentityUserRole<Guid>> CreateUsersRole()
        {
            IEnumerable<IdentityUserRole<Guid>> usersRole = new SeedsData().SeedUsersRole();

            return usersRole;
        }

        private IEnumerable<ApplicationRole> CreateRoles()
        {
            IEnumerable<ApplicationRole> roles = new SeedsData().SeedRole();

            foreach (var role in roles)
            {
                role.NormalizedName = role.Name.ToUpper();
            }

            return roles;
        }

        private IEnumerable<ApplicationUser> CreateUsers()
        {
            const string Password = "Aa123456";

            IEnumerable<ApplicationUser> users = new SeedsData().SeedUsers();

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            foreach (var user in users)
            {
                user.NormalizedUserName = user.UserName.ToUpper();
                user.PasswordHash = hasher.HashPassword(user, Password);
                user.SecurityStamp = Guid.NewGuid().ToString();
            }

            return users;
        }

        private IEnumerable<ChangedSchedule> CreateChangedSchedule()
        {
            var schedulesModel = this.Reader(new List<ChangedScheduleTransferModel>());

            List<ChangedSchedule> schedules = new List<ChangedSchedule>();

            IEnumerable<ApplicationUser> users = new SeedsData().SeedUsers();
            IEnumerable<WorkingShift> workingShifts = new SeedsData().SeedWorkingShift();

            DateTime currentDate = DateTime.Now.Date;

            foreach (var schedule in schedulesModel)
            {
                var user = users.FirstOrDefault(u => u.UserWorkNumber == schedule.UseNumber);

                if (!(user is null))
                {
                    for (int i = 0; i < schedule.MonthlyDistribution.Length; i++)
                    {
                        var shiftForDay = schedule.MonthlyDistribution[i];
                        var shift = workingShifts
                            .FirstOrDefault(ws => ws.ShiftName.ToUpper().Equals(shiftForDay.ToUpper()));

                        if (!(shift is null))
                        {
                            ChangedSchedule newChangedSchedule = new ChangedSchedule()
                            {
                                ApplicationUserId = user.Id,
                                ShiftId = shift.Id,
                                Date = currentDate.AddDays(i)
                            };

                            schedules.Add(newChangedSchedule);
                        }
                    }
                }
            }

            return schedules;
        }

        private IEnumerable<ChangedScheduleTransferModel> Reader(IList<ChangedScheduleTransferModel> model)
        {
            string PathSeedFile = @"..\..\..\..\SafeAssignmentSystem\wwwroot\Seed.xlsx";

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            try
            {
                using (var stream = File.Open(PathSeedFile, FileMode.Open, FileAccess.Read))
                {
                    ExcelPackage package = new ExcelPackage();
                    package.Load(stream);

                    using (ExcelWorksheet workSheet = package.Workbook.Worksheets.First())
                    {
                        int noOfRow = workSheet.Dimension.End.Row;
                        int rowIndex = 3;
                        int colStartIndex = 4;
                        int colSerNumIndex = 2;

                        for (int r = rowIndex; r <= noOfRow; r++)
                        {
                            var scheduleModel = new ChangedScheduleTransferModel(31);

                            bool isValid = int.TryParse(workSheet.Cells[r, colSerNumIndex].Text, out int num);
                            if (isValid)
                            {
                                scheduleModel.UseNumber = num;

                                for (int c = 0; c < scheduleModel.MonthlyDistribution.Length; c++)
                                {
                                    scheduleModel.MonthlyDistribution[c] = workSheet.Cells[r, colStartIndex + c].Text.ToUpper();
                                }

                                model.Add(scheduleModel);
                            }
                        }
                    }
                }
            }
            catch (IOException ioe)
            {
                throw ioe;
            }

            return model;
        }

        protected async Task SetTestSafeAssignmentInBase(SafeAssignmentTransferModel testModel)
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

        protected async Task<SafeAssignmentTransferModel> CreateTestSafeAssignment(TechnologicalPosition position)
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

        protected async Task<SafeAssignmentTransferModel> OpeningTestSafeAssignmentAsync(TechnologicalPosition position)
        {
            var newSafeAssignment = await this.CreateTestSafeAssignment(position);
            var time = DateTime.Now;
            newSafeAssignment.ЕlectricianOpeningOrderId = this.electricianId;
            newSafeAssignment.OpeningDate = new DateOnly(time.Year, time.Month, time.Day);
            newSafeAssignment.OpeningTime = new TimeOnly(time.Hour, time.Minute);
            newSafeAssignment.Status = StatusFlagsEnum.Opening;

            return newSafeAssignment;
        }

        protected async Task<SafeAssignmentTransferModel> ClosingTestSafeAssignmentAsync(TechnologicalPosition position)
        {
            var newSafeAssignment = await this.OpeningTestSafeAssignmentAsync(position);
            var time = DateTime.Now;
            newSafeAssignment.ЕlectricianClosingOrderId = this.electricianId;
            newSafeAssignment.ClosingDate = new DateOnly(time.Year, time.Month, time.Day);
            newSafeAssignment.ClosingTime = new TimeOnly(time.Hour, time.Minute);
            newSafeAssignment.Status = StatusFlagsEnum.Closing;

            return newSafeAssignment;
        }

        protected async Task<SafeAssignmentTransferModel> RequiredTestSafeAssignmentAsync(TechnologicalPosition position)
        {
            var newSafeAssignment = await this.ClosingTestSafeAssignmentAsync(position);

            newSafeAssignment.PersonRequestedVoltageSupplyId = this.operatorId;
            newSafeAssignment.Status = StatusFlagsEnum.Required;

            return newSafeAssignment;
        }

        protected async Task<SafeAssignmentTransferModel> ArchivedTestSafeAssignmentAsync(TechnologicalPosition position)
        {
            var newSafeAssignment = await this.ClosingTestSafeAssignmentAsync(position);

            newSafeAssignment.ElectricianAppliedVoltageId = this.electricianId;
            newSafeAssignment.Status = StatusFlagsEnum.Archived;

            return newSafeAssignment;
        }
    }
}