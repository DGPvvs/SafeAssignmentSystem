namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;

    public class ApplicationUserPlantInstalationSeeder : IEntityTypeConfiguration<ApplicationUserPlantInstalation>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserPlantInstalation> builder)
        {
            builder.HasData(new SeedsData().SeedApplicationUserPlantInstalation());
        }
    }
}
