using ESN_Api.ESN_Api.dal.ViewModels;

namespace ESN_Api.ESN_Api.dal.Repositories
{
    public interface INotificationRepository
    {
        Task<bool> AddNotification(int articleId);
        Task DeleteNotification(int notificationId);
        Task<List<NotificationVM>> Get50Notifications();
        Task<List<NotificationVM>> Get50UserNotifications(int userId);
        Task MarkNotificationAsRead(int notificationId, int userId);
    }
}
