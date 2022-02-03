using ESN_Api.ESN_Api.dal.Repositories;
using ESN_Api.ESN_Api.dal.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ESN_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationRepository _notificationRepository;
        public NotificationController(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        [HttpPost("notification")]
        public async Task<bool> AddNotification([FromBody] int articleId)
        {
            return await _notificationRepository.AddNotification(articleId);
        }

        [HttpGet("notifications")]
        public async Task<List<NotificationVM>> GetNotifications()
        {
            return await _notificationRepository.Get50Notifications();
        }

        [HttpGet("user-notifications")]
        public async Task<List<NotificationVM>> GetUserNotifications(int userId)
        {
            return await _notificationRepository.Get50UserNotifications(userId);
        }

        [HttpPut("notification")]
        public async Task MarkNotificationAsRead(int notificationId, int userId)
        {
            await _notificationRepository.MarkNotificationAsRead(notificationId, userId);
        }

        [HttpDelete("notification")]
        public async Task DeleteNotification(int notificationId)
        {
            await _notificationRepository.DeleteNotification(notificationId);
        }
    }
}