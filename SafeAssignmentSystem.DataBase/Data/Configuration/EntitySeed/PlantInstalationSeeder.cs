namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;

    internal class PlantInstalationSeeder : IEntityTypeConfiguration<PlantInstalation>
    {
        public void Configure(EntityTypeBuilder<PlantInstalation> builder)
        {
            builder.HasData(new SeedsData().SeedPlantInstalation());
        }
    }
}
