using ESN_WinForm.Helpers;
using System.Threading.Tasks;

namespace ESN_WinForm.Services
{
    public static class NotificationService
    {
        private static readonly string baseURL = "http://localhost:8012/Notification/";

        public static async Task<string> Add(int articleId)
        {
            return await HTTPClient.Post(baseURL, "notification", articleId);
        }

        public static async Task Delete(int notificationId)
        {
            await HTTPClient.Delete(baseURL, "notification?notificationId=", notificationId);
        }
    }
}
