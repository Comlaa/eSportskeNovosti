using ESN_Api.ESN_Api.dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ESN_Api.Configuration
{
    public class UserNotificationConfiguration : BaseEntityConfiguration<UserNotification>
    {
        public override void Configure(EntityTypeBuilder<UserNotification> builder)
        {
            base.Configure(builder);

            builder.HasData(new UserNotification
            {
                Id = 1,
                UserId = 3,
                NotificationId = 1,
                Read = false,
                CreatedAt = DateTime.Now,
            });
        }
    }
}
