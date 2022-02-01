using ESN_Api.ESN_Api.dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ESN_Api.Configuration
{
    public class NotificationConfiguration : BaseEntityConfiguration<Notification>
    {
        public override void Configure(EntityTypeBuilder<Notification> builder)
        {
            base.Configure(builder);

            builder.HasData(new Notification
            {
                Id = 1,
                ArticleId = 1,
                NotificationDate = DateTime.Now,
                CreatedAt = DateTime.Now,
            });
        }
    }
}
