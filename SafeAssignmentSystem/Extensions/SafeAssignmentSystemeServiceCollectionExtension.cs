namespace Microsoft.Extensions.DependencyInjection
{
	using SafeAssignmentSystem.Core.Contracts;
	using SafeAssignmentSystem.Core.Service;
	using SafeAssignmentSystem.DataBase.Data.Common;

	public static class SafeAssignmentSystemeServiceCollectionExtension
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{			
			services.AddScoped<IRepository, Repository>();
			services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IPlantsService, PlantsService>();
            services.AddScoped<IChoisPlantsService, ChoisPlantsService>();
            services.AddScoped<IWorkingRotationService, WorkingRotationService>();

            return services;
		}
	}
}
