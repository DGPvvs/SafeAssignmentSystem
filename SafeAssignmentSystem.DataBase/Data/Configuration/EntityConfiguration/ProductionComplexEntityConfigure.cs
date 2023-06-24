namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;

    internal class ProductionComplexEntityConfigure : IEntityTypeConfiguration<ProductionComplex>
    {
        public void Configure(EntityTypeBuilder<ProductionComplex> builder)
        {
            builder
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);
        }
    }
}
