namespace SafeAssignmentSystem.Core.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.DataBase.Data.Configuration;
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
			modelBuilder.Entity<ChangedSchedule>().HasKey(ck => new
            {
                ck.Date,
                ck.ApplicationUserId
            });

            modelBuilder.Entity<ApplicationUserPlantInstalation>().HasKey(ui => new
            {
                ui.UserId,
                ui.InstalationId
            });

            modelBuilder.Entity<ApplicationUserPlantInstalation>()
                .HasOne(x => x.Instalation)
                .WithMany(b => b.ApplicationUserPlantInstalations)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ProductionComplex>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.ApplyConfiguration(new ProductionComplexConfiguration());
            modelBuilder.ApplyConfiguration(new PlantInstalationConfiguration());
            modelBuilder.ApplyConfiguration(new TechnologicalPositionConfiguration());
            modelBuilder.ApplyConfiguration(new WorkingShiftConfiguration());            

            base.OnModelCreating(modelBuilder);
		}
	}
}