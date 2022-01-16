using ESN_Api.ESN_Api.dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ESN_Api.Configuration
{
    public class FavouriteConfiguration : BaseEntityConfiguration<Favourite>
    {
        public override void Configure(EntityTypeBuilder<Favourite> builder)
        {
            base.Configure(builder);

            builder.HasData(new Favourite
            {
                Id = 1,
                UserId = 3,
                CreatedAt = DateTime.UtcNow,
                Tags = "Barcelona",
            });
        }
    }
}
