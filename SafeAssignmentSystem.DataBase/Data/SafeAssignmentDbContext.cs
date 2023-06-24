namespace SafeAssignmentSystem.Core.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.DataBase.Data.Configuration;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntityConfiguration;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.SafeAssignmentDocumentModels;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.StaffsModels;
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;
        
    public class SafeAssignmentDbContext : IdentityDbContext<ApplicationUser>
    {
        public SafeAssignmentDbContext(DbContextOptions<SafeAssignmentDbContext> options)
            : base(options)
        {
        }

        public DbSet<PlantInstalation> PlantInstalations { get; set; } = null!;

        public DbSet<ProductionComplex> ProductionComplexes { get; set; } = null!;

        public DbSet<TechnologicalPosition> TechnologicalPositions { get; set; } = null!;

        public DbSet<WorkingShift> WorkingShifts { get; set; } = null!;

        public DbSet<ChangedSchedule> ChangedsSchedules { get; set; } = null!;

        public DbSet<ApplicationUserPlantInstalation> ApplicationUserPlantInstalations { get; set; } = null!;

        public DbSet<SafeAssignmentDocument> SafeAssignmentDocuments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            // Конфигуриране на моделите на базата
            modelBuilder.ApplyConfiguration(new ChangedScheduleEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserPlantInstalationEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductionComplexEntityConfigure());

            // Зареждане на тестовите данни в базата
            modelBuilder.ApplyConfiguration(new ProductionComplexSeeder());
            modelBuilder.ApplyConfiguration(new PlantInstalationSeeder());
            modelBuilder.ApplyConfiguration(new TechnologicalPositionSeeder());
            modelBuilder.ApplyConfiguration(new WorkingShiftSeeder());
            modelBuilder.ApplyConfiguration(new ApplicationUserSeeder());
            modelBuilder.ApplyConfiguration(new ChangedScheduleSeede());
            modelBuilder.ApplyConfiguration(new ApplicationUserPlantInstalationSeeder());

            base.OnModelCreating(modelBuilder);
		}
	}
}