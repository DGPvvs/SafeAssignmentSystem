namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;

    /// <summary>
    /// Клас зареждащ свързващата таблица с потребители имащи права върху инсталации
    /// </summary>
    public class ApplicationUserPlantInstalationSeeder : IEntityTypeConfiguration<ApplicationUserPlantInstalation>
    {
        /// <summary>
        /// Метод конфигуриращ свързващата таблица
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<ApplicationUserPlantInstalation> builder)
        {
            builder.HasData(new SeedsData().SeedApplicationUserPlantInstalation());
        }
    }
}
