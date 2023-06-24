namespace Microsoft.Extensions.DependencyInjection
{
	using SafeAssignmentSystem.DataBase.Data.Common;

	public static class SafeAssignmentSystemeServiceCollectionExtension
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{			
			services.AddScoped<IRepository, Repository>();
            return services;
		}
	}
}
