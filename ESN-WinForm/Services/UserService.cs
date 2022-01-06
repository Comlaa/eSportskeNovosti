using ESN_WinForm.DTO;
using ESN_WinForm.Helpers;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace ESN_WinForm.Services
{
    public static class UserService
    {
        private static readonly string baseURL = "https://localhost:8012/User/";

        public static async Task<string> GetAllUsers()
        {
            return await HTTPClient.Get(baseURL, "users");
        }

        public static async Task<string> GetAllUsersByUsername(string search)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(baseURL + "users-by-username?username="+search))
                {
                    using (HttpContent content = response.Content)
                    {
                        return await content.ReadAsStringAsync() ?? "No data!";
                    }
                }
            }
        }
        
        public static async Task<bool> Login(string username, string password)
        {
            LoginDTO loginData = new LoginDTO { Username = username, Password = password };   

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PutAsJsonAsync(baseURL + "login", loginData))
                {
                    using (HttpContent content = response.Content)
                    {
                        var loginResponse = await content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<bool>(loginResponse);
                    }
                }
            }
        }
    }
}
