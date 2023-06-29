namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData;
    using System;
    using System.Collections.Generic;

    internal class UserRoleSeeder : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(CreateUsersRole());
        }

        private IEnumerable<IdentityUserRole<Guid>> CreateUsersRole()
        {
            IEnumerable<IdentityUserRole<Guid>> usersRole = new SeedsData().SeedUsersRole();

            return usersRole;
        }
    }
}
