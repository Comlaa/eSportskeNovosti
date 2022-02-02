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
                Id = 100,
                ArticleId = 1,
                NotificationDate = new DateTime(2022, 2, 2, 18, 00, 00, DateTimeKind.Utc),
                CreatedAt = new DateTime(2022, 2, 2, 18, 00, 00, DateTimeKind.Utc),
            });
        }
    }
}
