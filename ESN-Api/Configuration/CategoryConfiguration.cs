using ESN_Api.ESN_Api.dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ESN_Api.Configuration
{
    public class CategoryConfiguration : BaseEntityConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);

            builder.HasData(new Category[]
            {
                new Category
                {
                     Id = 1,
                    Name = "Fudbal",
                    Description = "Fudbal je igra koja je nastala u Evropi. Engleska premier liga je jedna od najpoznatijih na svijetu.",
                    CreatedAt = DateTime.Now,
                },
                new Category
                {
                    Id = 2,
                    Name = "Rukomet",
                    Description = "Visoko je poznato po rukometu.",
                    CreatedAt = DateTime.Now,
                },
                new Category
                {
                    Id = 3,
                    Name = "Tenis",
                    Description = "Nadal je jedan od najboljih tenisera svijeta.",
                    CreatedAt = DateTime.Now,
                },
            });
        }
    }
}
