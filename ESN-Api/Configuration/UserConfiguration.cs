using ESN_Api.ESN_Api.dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ESN_Api.Configuration
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.HasData(new User[]
         {
                new User()
                {
                    Id = 1,
                    FirstName = "desktop",
                    Lastname = "",
                    Username = "desktop",
                    Email = "desktop@mail.com",
                    GenderId = 1,
                    CreatedAt= new DateTime(2022, 1, 2, 18, 00, 00, DateTimeKind.Utc),
                    PasswordHash = "ExhCoLc0RVU6e1K2veoRh6dUP4FRE2uyFXAkQrsPYKc=",
                    PasswordSalt = "ohIp8ucWEgzGRvqMbu3InQ=="
                },
                new User()
                {
                    Id = 2,
                    FirstName = "mobile",
                    Lastname = "",
                    Username = "mobile",
                    Email = "mobile@mail.com",
                    GenderId = 1,
                    CreatedAt= new DateTime(2022, 1, 2, 18, 00, 00, DateTimeKind.Utc),
                    PasswordHash = "ExhCoLc0RVU6e1K2veoRh6dUP4FRE2uyFXAkQrsPYKc=",
                    PasswordSalt = "ohIp8ucWEgzGRvqMbu3InQ=="
                },
                new User()
                {
                    Id = 3,
                    FirstName = "korisnik",
                    Lastname = "",
                    Username = "korisnik",
                    Email = "korisnik@mail.com",
                    GenderId = 1,
                    CreatedAt= new DateTime(2022, 1, 2, 18, 00, 00, DateTimeKind.Utc),
                    PasswordHash = "ExhCoLc0RVU6e1K2veoRh6dUP4FRE2uyFXAkQrsPYKc=",
                    PasswordSalt = "ohIp8ucWEgzGRvqMbu3InQ=="
                },
        });

        }
    }
}