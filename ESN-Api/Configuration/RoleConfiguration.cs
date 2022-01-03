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
                    Permissions = "Read, Write, Edit, Create, Delete",
                    CreatedAt= new DateTime(2022, 1, 2, 18, 00, 00, DateTimeKind.Utc)
                },
                new Role
                {
                    Id=2,
                    Name="Editor",
                    Permissions = "Read, Write, Edit",
                    CreatedAt= new DateTime(2022, 1, 2, 18, 00, 00, DateTimeKind.Utc)
                },
                new Role
                {
                    Id=3,
                    Name="User",
                    Permissions = "Read",
                    CreatedAt= new DateTime(2022, 1, 2, 18, 00, 00, DateTimeKind.Utc)
                },
            });
        }
    }
}
