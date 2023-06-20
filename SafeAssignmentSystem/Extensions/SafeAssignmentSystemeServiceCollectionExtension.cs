namespace Microsoft.Extensions.DependencyInjection
{
	using SafeAssignmentSystem.DataBase.Data.Common;

	public static class SafeAssignmentSystemeServiceCollectionExtension
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{
			services.AddScoped<IRepository, Repository>();
			//services.AddScoped<IHouseService, HouseService>();
			//services.AddScoped<IAgentService, AgentService>();
			return services;
		}
	}
}
