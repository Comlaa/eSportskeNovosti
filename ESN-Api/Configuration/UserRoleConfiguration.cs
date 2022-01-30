using ESN_Api.ESN_Api.dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ESN_Api.Configuration
{
    public class UserRoleConfiguration : BaseEntityConfiguration<UserRole>
    {
        public override void Configure(EntityTypeBuilder<UserRole> builder)
        {
            base.Configure(builder);

            builder.HasOne(p => p.User)
                   .WithMany(p => p.Roles)
                   .HasForeignKey(p => p.RoleId);

            builder.HasOne(p => p.Role)
                   .WithMany(p => p.Users)
                   .HasForeignKey(p => p.UserId);

            builder.HasData(new List<UserRole>
            {
                new UserRole {Id=1, UserId=1, RoleId = 1 },
                new UserRole {Id=2, UserId=2, RoleId = 1 },
                new UserRole {Id=3, UserId=3, RoleId = 3 },
            }
            );
        }
    }
}
