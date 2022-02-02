using ESN_WinForm.Helpers;
using System.Threading.Tasks;

namespace ESN_WinForm.Services
{
    public static class CategoryService
    {
        private static readonly string baseURL = "http://localhost:8012/Category/";

        public static async Task<string> GetAllCategories()
        {
            return await HTTPClient.Get(baseURL, "categories");
        }

        public static async Task<string> GetCategoryById(int categoryId)
        {
            return await HTTPClient.Get(baseURL, "category?categoryId=", categoryId);
        }

        public static async Task<string> GetAllCategorysByName(string name)
        {
            return await HTTPClient.Get(baseURL, "categories-by-name?name=", name);
        }

        public static async Task<string> Add(CategoryDTO category)
        {
            return await HTTPClient.Post(baseURL, "category", category);
        }
        public static async Task Edit(CategoryDTO category)
        {
            await HTTPClient.Put(baseURL, "category", category);
        }

        public static async Task Delete(int categoryId)
        {
            await HTTPClient.Delete(baseURL, "category?categoryId=", categoryId);
        }
    }
}
