namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.StaffsModels;

    internal class ChangedScheduleEntityConfiguration : IEntityTypeConfiguration<ChangedSchedule>
    {
        public void Configure(EntityTypeBuilder<ChangedSchedule> builder)
        {
            builder
                .HasKey(ck => new
                {
                    ck.Date,
                    ck.ApplicationUserId
                });
        }
    }
}
