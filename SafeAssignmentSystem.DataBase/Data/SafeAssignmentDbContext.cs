namespace SafeAssignmentSystem.Core.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.DataBase.Data.Account;
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;
    using SafeAssignmentSystem.DataBase.Data.StaffsModels;

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

            base.OnModelCreating(modelBuilder);
		}
	}
}