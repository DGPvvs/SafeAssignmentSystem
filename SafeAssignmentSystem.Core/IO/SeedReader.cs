namespace SafeAssignmentSystem.Core.IO
{
    using Microsoft.AspNetCore.Http;
    using OfficeOpenXml;
    using SafeAssignmentSystem.Common.IO.Contracts;
    using SafeAssignmentSystem.Core.Models.TransferModels;
    using System.Collections.Generic;
    using System.Linq;

    internal class SeedReader : IReader
    {
        public IEnumerable<ChangedScheduleTransferModel> ReadData(IFormFile file, IList<ChangedScheduleTransferModel> model)
        {
            const string PathSeedFile = @"../../../../SafeAssignmentSystem.DataBase/bin/Debug/Debug/Seed.xlsx";

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
                        scheduleModel.UseNumber = int.Parse(workSheet.Cells[rowIndex, colSerNumIndex].Text);

                        for (int c = 0; c < scheduleModel.MonthlyDistribution.Length; c++)
                        {
                            scheduleModel.MonthlyDistribution[c] = workSheet.Cells[r, colStartIndex + c].Text.ToUpper();
                        }

                        model.Add(scheduleModel);
                    }
                }
            }

            return model;
        }
    }
}
