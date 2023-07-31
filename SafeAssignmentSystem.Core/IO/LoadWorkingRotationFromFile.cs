namespace SafeAssignmentSystem.Core.IO
{
    using Microsoft.AspNetCore.Http;
    using OfficeOpenXml;
    using SafeAssignmentSystem.Common.IO.Contracts;
    using SafeAssignmentSystem.Core.Models.TransferModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Клас имплементиращ функционалности за четене на сменен график от файл
    /// </summary>
    public class LoadWorkingRotationFromFile : IReader
    {
        /// <summary>
        /// Имплементация на метод за четене на сменен график от файлов стриим
        /// </summary>
        /// <param name="file"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public IEnumerable<ChangedScheduleTransferModel> ReadData(IFormFile file, IList<ChangedScheduleTransferModel> model)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            try
            {
                using (var stream = file.OpenReadStream())
                {
                    ExcelPackage package = new ExcelPackage();
                    package.Load(stream);

                    using (ExcelWorksheet workSheet = package.Workbook.Worksheets.First())
                    {
                        int monthRow = 2;
                        int monthCol = 2;

                        int yearRow = 2;
                        int yearCol = 3;

                        bool isMonthValid = int.TryParse(workSheet.Cells[monthRow, monthCol].Text, out int month);
                        bool isYearValid = int.TryParse(workSheet.Cells[yearRow, yearCol].Text, out int year);

                        if (!isMonthValid || !isYearValid)
                        {
                            throw new Exception();
                        }

                        DateOnly date = new DateOnly(year, month, 1);

                        int arrayLength = date.AddMonths(1).AddDays(-1).Day;                        

                        int noOfRow = workSheet.Dimension.End.Row;
                        int rowIndex = 6;
                        int colStartIndex = 6;
                        int colSerNumIndex = 4;

                        for (int r = rowIndex; r <= noOfRow; r++)
                        {
                            var scheduleModel = new ChangedScheduleTransferModel(arrayLength);

                            bool isValid = int.TryParse(workSheet.Cells[r, colSerNumIndex].Text, out int num);
                            if (isValid)
                            {
                                scheduleModel.UseNumber = num;
                                scheduleModel.Date = date;

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