namespace SafeAssignmentSystem.Tests.UnitTests
{
    using Microsoft.AspNetCore.Identity;
    using OfficeOpenXml;
    using SafeAssignmentSystem.Core.Data;
    using SafeAssignmentSystem.DataBase.Data.Common;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.StaffsModels;
    using SafeAssignmentSystem.Tests.Mocks;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UnitTestsBase
    {
        protected SafeAssignmentDbContext context;
        protected IRepository repo;

        [OneTimeSetUp]
        public void SetUpBase()
        {
            this.context = DataBaseMock.Instance;
            this.repo = new Repository(this.context);
            this.SeedDataBase();
        }

        //public IEnumerable<PlantInstalation> PlantInstalation { get; set; } = null!;
        //public ProductionComplex ProductionComplex { get; set; } = null!;
        //public TechnologicalPosition TechnologicalPosition { get; set; } = null!;
        //public WorkingShift WorkingShift { get; set; } = null!;
        //public ChangedSchedule ChangedSchedule { get; set; } = null!;
        //public ApplicationUserPlantInstalation ApplicationUserPlantInstalation { get; set; } = null!;
        //public SafeAssignmentDocument SafeAssignmentDocument { get; set; } = null!;
        //public ApplicationRole ApplicationRole { get; set; } = null!;
        //public ApplicationUser ApplicationUser { get; set; } = null!;


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
    }
}