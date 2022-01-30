using ESN_Api.ESN_Api.dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ESN_Api.Configuration
{
    public class SavedArticleConfiguration : BaseEntityConfiguration<SavedArticle>
    {
        public override void Configure(EntityTypeBuilder<SavedArticle> builder)
        {
            base.Configure(builder);

            builder.HasData(new SavedArticle
            {
                Id = 1,
                ArticleId = 1,
                UserId = 3
            });
        }
    }
}
