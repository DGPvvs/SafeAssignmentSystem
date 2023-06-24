namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData;
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;

    internal class TechnologicalPositionSeeder : IEntityTypeConfiguration<TechnologicalPosition>
    {
        public void Configure(EntityTypeBuilder<TechnologicalPosition> builder)
        {
            builder.HasData(new SeedsData().SeedTechnologicalPosition());
        }
    }
}
