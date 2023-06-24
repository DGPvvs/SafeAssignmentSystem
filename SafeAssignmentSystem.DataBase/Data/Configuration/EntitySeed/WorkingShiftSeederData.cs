namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed
{
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.StaffsModels;
    using System;
    using System.Collections.Generic;

    internal class WorkingShiftSeederData
    {
        public IEnumerable<WorkingShift> SeedWorkingShift() =>
            new List<WorkingShift>()
            {
                new WorkingShift()
                {
                    Id = Guid.Parse("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d"),
                    ShiftName = "Р",
                    StartTime = new DateTime(1, 1, 1) + new TimeOnly(7, 30).ToTimeSpan(),
                    EndTime = new DateTime(1, 1, 1) + new TimeOnly(16, 0).ToTimeSpan()
                },

                new WorkingShift()
                {
                    Id = Guid.Parse("51e3023b-5967-4221-ba1e-977fdff10eda"),
                    ShiftName = "1",
                    StartTime = new DateTime(1, 1, 1) + new TimeOnly(7, 0).ToTimeSpan(),
                    EndTime = new DateTime(1, 1, 1) + new TimeOnly(19, 0).ToTimeSpan()
                },

                new WorkingShift()
                {
                    Id = Guid.Parse("ad095ab8-ed2b-4f15-9f2d-088188db4ee2"),
                    ShiftName = "2",
                    StartTime = new DateTime(1, 1, 1) + new TimeOnly(19, 0).ToTimeSpan(),
                    EndTime = new DateTime(1, 1, 2) + new TimeOnly(7, 0).ToTimeSpan()
                }
            };

    }
}
