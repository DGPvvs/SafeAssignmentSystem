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

    /// <summary>
    /// DbContext на приложението
    /// </summary>
    public class SafeAssignmentDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
	{
        /// <summary>
        /// Конструктор на SafeAssignmentDbContext 
        /// </summary>
        /// <param name="options"></param>
        public SafeAssignmentDbContext(DbContextOptions<SafeAssignmentDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Модел на таблицата с инсталации в базата данни
        /// </summary>
        public DbSet<PlantInstalation> PlantInstalations { get; set; } = null!;

        /// <summary>
        /// Модел на таблицата с комплекси в базата данни
        /// </summary>
        public DbSet<ProductionComplex> ProductionComplexes { get; set; } = null!;

        /// <summary>
        /// Модел на таблицата с технологичните позиции в базата данни
        /// </summary>
        public DbSet<TechnologicalPosition> TechnologicalPositions { get; set; } = null!;


        /// <summary>
        /// Модел ва таблицата със смените в базата данни
        /// </summary>
        public DbSet<WorkingShift> WorkingShifts { get; set; } = null!;


        /// <summary>
        /// Модел на таблицата със сменният график в базата данни
        /// </summary>
        public DbSet<ChangedSchedule> ChangedsSchedules { get; set; } = null!;


        /// <summary>
        /// Модел на свързващата таблица между потребителите и инсталациите в базата данни 
        /// </summary>
        public DbSet<ApplicationUserPlantInstalation> ApplicationUserPlantInstalations { get; set; } = null!;


        /// <summary>
        /// Модел на таблицата с нарядите в базата данни
        /// </summary>
        public DbSet<SafeAssignmentDocument> SafeAssignmentDocuments { get; set; } = null!;

        /// <summary>
        /// Конфигуриране на базата данни
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            // Конфигуриране на моделите на базата
            modelBuilder.ApplyConfiguration(new ChangedScheduleEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserPlantInstalationEntityConfiguration());

            // Зареждане на тестовите данни в базата
            modelBuilder.ApplyConfiguration(new ProductionComplexSeeder());
            modelBuilder.ApplyConfiguration(new PlantInstalationSeeder());
            modelBuilder.ApplyConfiguration(new TechnologicalPositionSeeder());
            modelBuilder.ApplyConfiguration(new WorkingShiftSeeder());
            modelBuilder.ApplyConfiguration(new RoleSeeder());
            modelBuilder.ApplyConfiguration(new ApplicationUserSeeder());
            modelBuilder.ApplyConfiguration(new UserRoleSeeder());
            //Debugger.Launch();
            modelBuilder.ApplyConfiguration(new ChangedScheduleSeede());
            modelBuilder.ApplyConfiguration(new ApplicationUserPlantInstalationSeeder());

            base.OnModelCreating(modelBuilder);
		}
	}
}