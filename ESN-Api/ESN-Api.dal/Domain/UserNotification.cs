namespace ESN_Api.ESN_Api.dal.Domain
{
    public class UserNotification : BaseEntity
    {
        public int NotificationId { get; set; }
        public Notification Notification { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public bool Read { get; set; }

        public UserNotification()
        {

        }

        public UserNotification(int notificationId, int userId)
        {
            NotificationId = notificationId;
            UserId = userId;
            Read = false;
        }
    }
}
