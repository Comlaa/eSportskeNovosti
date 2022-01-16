using ESN_Api.ESN_Api.dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ESN_Api.Configuration
{
    public class ArticleRatingsConfiguration : BaseEntityConfiguration<ArticleRating>
    {
        public override void Configure(EntityTypeBuilder<ArticleRating> builder)
        {
            base.Configure(builder);

            builder.HasData(new ArticleRating[]
            {
                new ArticleRating
                {
                    Id = 1,
                    UserId = 3,
                    ArticleId = 1,
                    Rating = 5,
                    CreatedAt = DateTime.Now,
                },
                new ArticleRating
                {
                    Id = 2,
                    UserId = 3,
                    ArticleId = 2,
                    Rating = 3,
                    CreatedAt = DateTime.Now,
                },
                new ArticleRating
                {
                    Id = 3,
                    UserId = 2,
                    ArticleId = 1,
                    Rating = 4,
                    CreatedAt = DateTime.Now,
                },
                new ArticleRating
                {
                    Id = 4,
                    UserId = 1,
                    ArticleId = 1,
                    Rating = 5,
                    CreatedAt = DateTime.Now,
                },
            });
        }
    }
}
