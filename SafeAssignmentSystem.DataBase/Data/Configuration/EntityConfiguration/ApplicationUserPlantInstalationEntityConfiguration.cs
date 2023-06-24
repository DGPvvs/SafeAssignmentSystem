namespace SafeAssignmentSystem.DataBase.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;

    internal class ApplicationUserPlantInstalationEntityConfiguration : IEntityTypeConfiguration<ApplicationUserPlantInstalation>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserPlantInstalation> builder)
        {
            builder
                .HasKey(ui => new
                {
                    ui.UserId,
                    ui.InstalationId
                });

            builder
                .HasOne(x => x.Instalation)
                .WithMany(b => b.ApplicationUserPlantInstalations)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
