using ESN_WinForm.DTO;
using ESN_WinForm.Helpers;
using System.Threading.Tasks;

namespace ESN_WinForm.Services
{
    public class RoleService
    {
        private static readonly string baseURL = "http://localhost:8012/Role/";

        public static async Task<string> GetAllRoles()
        {
            return await HTTPClient.Get(baseURL, "roles");
        }

        public static async Task<string> GetRoleById(int roleId)
        {
            return await HTTPClient.Get(baseURL, "role?roleId=", roleId);
        }

        public static async Task<string> GetAllRolesByName(string name)
        {
            return await HTTPClient.Get(baseURL, "roles-by-name?name=", name);
        }

        public static async Task<string> Add(RoleDTO role)
        {
            return await HTTPClient.Post(baseURL, "role", role);
        }
        public static async Task Edit(RoleDTO role)
        {
            await HTTPClient.Put(baseURL, "role", role);
        }

        public static async Task Delete(int roleId)
        {
            await HTTPClient.Delete(baseURL, "role?roleId=", roleId);
        }
    }
}
