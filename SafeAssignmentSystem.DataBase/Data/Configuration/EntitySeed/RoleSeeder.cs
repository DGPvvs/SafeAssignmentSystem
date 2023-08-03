namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;

    public class RoleSeeder : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasData(CreateRoles());
        }

        private IEnumerable<ApplicationRole> CreateRoles()
        {
            IEnumerable<ApplicationRole> roles = new SeedsData().SeedRole();

            foreach (var role in roles)
            {
                role.NormalizedName = role.Name.ToUpper();
            }

            return roles;
        }
    }
}
