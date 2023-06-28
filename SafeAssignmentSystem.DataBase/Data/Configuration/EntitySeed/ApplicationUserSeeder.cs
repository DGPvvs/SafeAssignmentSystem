namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using System.Collections.Generic;

    internal class ApplicationUserSeeder : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private IEnumerable<ApplicationUser> CreateUsers()
        {
            const string Password = "Aa123456";

            IEnumerable<ApplicationUser> users = new SeedsData().SeedUsers();

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            foreach (var user in users)
            {
                user.NormalizedUserName = user.UserName.ToUpper();
                user.PasswordHash = hasher.HashPassword(user, Password);
                user.SecurityStamp = Guid.NewGuid().ToString();
			}

            return users;
        }

    }
}
