namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.StaffsModels;
    using System;
    using System.Collections.Generic;

    internal class WorkingShiftSeeder : IEntityTypeConfiguration<WorkingShift>
    {
        public void Configure(EntityTypeBuilder<WorkingShift> builder)
        {
            builder.HasData(new WorkingShiftSeederData().SeedWorkingShift());
        }
    }
}
