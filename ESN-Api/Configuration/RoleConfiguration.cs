using ESN_Api.ESN_Api.dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ESN_Api.Configuration
{
    public class RoleConfiguration : BaseEntityConfiguration<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);

            builder.HasData(new Role[]
            {
                new Role
                {
                    Id=1,
                    Name="Admin",
                    Description = "Admin related role. Admin has all the rights on the system.",
                    CreatedAt= new DateTime(2022, 1, 2, 18, 00, 00, DateTimeKind.Utc)
                },
                new Role
                {
                    Id=2,
                    Name="Editor",
                    Description = "Editor related role. Has less rights than admin, but more than User role",
                    CreatedAt= new DateTime(2022, 1, 2, 18, 00, 00, DateTimeKind.Utc)
                },
                new Role
                {
                    Id=3,
                    Name="User",
                    Description = "User related role",
                    CreatedAt= new DateTime(2022, 1, 2, 18, 00, 00, DateTimeKind.Utc)
                },
            });
        }
    }
}
