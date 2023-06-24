namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;

    internal class ProductionComplexSeeder : IEntityTypeConfiguration<ProductionComplex>
    {
        public void Configure(EntityTypeBuilder<ProductionComplex> builder)
        {
            builder.HasData(new SeedsData().SeedComplex());
        }

    }
}
