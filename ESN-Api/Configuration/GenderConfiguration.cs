using ESN_Api.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ESN_Api.Configuration
{
    public class GenderConfiguration : BaseEntityConfiguration<Gender>
    {
        public override void Configure(EntityTypeBuilder<Gender> builder)
        {
            base.Configure(builder);

            builder.HasMany(p => p.Users)
                   .WithOne(p => p.Gender)
                   .HasForeignKey(p => p.GenderId);

            builder.HasData(new Gender[]
            {
                new Gender
                {
                    Id = 1,
                    Name="Male",
                    CreatedAt= new DateTime(2022, 1, 2, 18, 00, 00, DateTimeKind.Utc)
                },
                new Gender
                {
                    Id = 2,
                    Name="Female",
                    CreatedAt= new DateTime(2022, 1, 2, 18, 00, 00, DateTimeKind.Utc)
                },
            });
        }
    }
}
