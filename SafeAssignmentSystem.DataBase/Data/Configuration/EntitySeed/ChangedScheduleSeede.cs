namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.Extensions.FileProviders;
    using OfficeOpenXml;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.StaffsModels;
    using System.Collections.Generic;

    internal class ChangedScheduleSeede : IEntityTypeConfiguration<ChangedSchedule>
    {
        public void Configure(EntityTypeBuilder<ChangedSchedule> builder)
        {            
            builder.HasData(this.CreateChangedSchedule());
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
			string PathSeedFile = Directory.GetCurrentDirectory() + @"\wwwroot\Seed.xlsx";

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

            }

            return model;
        }
    }
}
