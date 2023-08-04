namespace Microsoft.Extensions.DependencyInjection
{
	using SafeAssignmentSystem.Common.IO.Contracts;
	using SafeAssignmentSystem.Core.Contracts;
	using SafeAssignmentSystem.Core.IO;
	using SafeAssignmentSystem.Core.Service;
	using SafeAssignmentSystem.DataBase.Data.Common;

	/// <summary>
	/// Клас менажиращ сървиси
	/// </summary>
	public static class SafeAssignmentSystemeServiceCollectionExtension
	{
		/// <summary>
		/// Метод инжектиращ сървиси в приложението
		/// </summary>
		/// <param name="services"></param>
		/// <returns></returns>
		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{			
			services.AddScoped<IRepository, Repository>();
			services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IPlantsService, PlantsService>();
            services.AddScoped<IChoisPlantsService, ChoisPlantsService>();
            services.AddScoped<IWorkingRotationService, WorkingRotationService>();
            services.AddScoped<ISafeAssignmentService, SafeAssignmentService>();
            services.AddScoped<IReader, LoadWorkingRotationFromFile>();
            services.AddScoped<IReferencesService, ReferencesService>();            

            return services;
		}
	}
}
