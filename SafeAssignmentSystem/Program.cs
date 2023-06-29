namespace SafeAssignmentSystem
{
    using Humanizer;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Core.Data;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using System.ComponentModel;
    using System;
    using Microsoft.Extensions.DependencyInjection;

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<SafeAssignmentDbContext>(options =>
                options.UseSqlServer(connectionString)
                       .UseLazyLoadingProxies());


            builder.Services.AddDatabaseDeveloperPageExceptionFilter();
            			
			builder.Services.AddDefaultIdentity<ApplicationUser>()
				.AddRoles<ApplicationRole>()
				.AddEntityFrameworkStores<SafeAssignmentDbContext>();
			

            builder.Services.Configure<IdentityOptions>(options =>
            {
                options.SignIn.RequireConfirmedAccount = builder.Configuration.GetValue<bool>("Identity:SingIn:RequireConfirmedAccount");
                options.Password.RequireDigit = builder.Configuration.GetValue<bool>("Identity:Password:RequireDigit");
                options.Password.RequireLowercase = builder.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");
                options.Password.RequireUppercase = builder.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");
                options.Password.RequiredLength = builder.Configuration.GetValue<int>("Identity:Password:RequiredLength");
            });

            builder.Services.AddControllersWithViews();

            builder.Services.AddApplicationServices();

            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Login";
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}