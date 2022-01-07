using ESN_WinForm.DTO;
using ESN_WinForm.Helpers;
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
            return await HTTPClient.Get(baseURL, "users-by-username?username=", search);
        }
        
        public static async Task<bool> Login(string username, string password)
        {
            LoginDTO loginData = new LoginDTO { Username = username, Password = password };

            return await HTTPClient.Put(baseURL, "login", loginData);
        }
    }
}
