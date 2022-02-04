using ESN_WinForm.DTO;
using ESN_WinForm.Helpers;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ESN_WinForm.Services
{
    public static class UserService
    {
        private static readonly string baseURL = "http://localhost:8012/User/";

        public static async Task<string> GetAllUsers()
        {
            return await HTTPClient.Get(baseURL, "users");
        }

        public static async Task<string> GetSupportTickets()
        {
            return await HTTPClient.Get(baseURL, "support-tickets");
        }

        public static async Task<string> GetAllUsersByUsername(string search)
        {
            return await HTTPClient.Get(baseURL, "users-by-username?username=", search);
        }

        public static async Task<string> Login(string username, string password)
        {

            var ISO_8859_1 = Encoding.GetEncoding("ISO-8859-1");
            var svcCredentials = Convert.ToBase64String(ISO_8859_1.GetBytes(username + ":" + password));
            LoginDTO loginData = new LoginDTO { Username = username, Password = password };
            Properties.Settings.Default.SvcSetting = svcCredentials;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Basic " + svcCredentials);
                using (HttpResponseMessage response = await client.PutAsJsonAsync(baseURL + "login", loginData))
                {
                    using (HttpContent content = response.Content)
                    {
                        return await content.ReadAsStringAsync();
                    }
                }
            }
        }
    }
}
