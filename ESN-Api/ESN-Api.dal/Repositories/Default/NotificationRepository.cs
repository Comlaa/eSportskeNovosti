using ESN_Api.ESN_Api.dal.Database;
using ESN_Api.ESN_Api.dal.Domain;
using ESN_Api.ESN_Api.dal.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ESN_Api.ESN_Api.dal.Repositories.Default
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly ESNDbContext _context;
        private readonly IArticleRepository _articleRepository;

        public NotificationRepository(ESNDbContext context, IArticleRepository articleRepository)
        {
            _context = context;
            _articleRepository = articleRepository;
        }

        public async Task<bool> AddNotification(int articleId)
        {
            var article = await _articleRepository.GetArticleById(articleId);
            if (article != null)
            {
                var alreadyNotified = await _context.Notifications.FirstOrDefaultAsync(n => n.ArticleId.Equals(articleId));

                if (alreadyNotified != null)
                    return false;

                var users = await _context.Users.Select(u => u.Id).ToListAsync();
                var notification = new Notification(articleId);

                await _context.Notifications.AddAsync(notification);
                await _context.SaveChangesAsync();

                foreach (var user in users)
                    await _context.UserNotifications.AddAsync(new UserNotification(notification.Id, user));

                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task DeleteNotification(int notificationId)
        {
            var notification = _context.Notifications.FirstOrDefault(x => x.Id.Equals(notificationId));

            if (notification != null)
            {
                _context.Notifications.Remove(notification);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<NotificationVM>> Get50Notifications()
        {
            return await _context.Notifications.Include(a => a.Article)
            .Take(50).Select(notification =>
            new NotificationVM(notification.Id, notification.Article, false)).ToListAsync();
        }

        public async Task<List<NotificationVM>> Get50UserNotifications(int userId)
        {
            return await _context.UserNotifications.Include(a => a.User)
            .Where(un => un.UserId.Equals(userId))
            .Join(_context.Notifications.Include(a => a.Article),
                un => un.NotificationId,
                n => n.Id,
                (un, n) =>
                new NotificationVM(n.Id, n.Article, un.Read))
            .Take(50).ToListAsync();
        }

        public async Task MarkNotificationAsRead(int notificationId, int userId)
        {
            var notification = _context.UserNotifications.Where(un => un.NotificationId == notificationId &&
                                                                      un.UserId == userId).FirstOrDefault();

            if (notification == null)
                throw new Exception("Notifikacija ne postoji u bazi za ovog korisnika.");


            notification.Read = true;
            _context.UserNotifications.Update(notification);
            await _context.SaveChangesAsync();
        }
    }
}
