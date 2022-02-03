using ESN_Api.ESN_Api.dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ESN_Api.Configuration
{
    public class UserNotificationConfiguration : BaseEntityConfiguration<UserNotification>
    {
        public override void Configure(EntityTypeBuilder<UserNotification> builder)
        {
            base.Configure(builder);

            builder.HasOne(p => p.User)
                   .WithMany(p => p.UserNotifications)
                   .HasForeignKey(p => p.UserId);

            builder.HasData(new UserNotification
            {
                Id = 2,
                UserId = 3,
                NotificationId = 2,
                Read = false,
                CreatedAt = new DateTime(2022, 2, 2, 18, 00, 00, DateTimeKind.Utc),
            });
        }
    }
}
