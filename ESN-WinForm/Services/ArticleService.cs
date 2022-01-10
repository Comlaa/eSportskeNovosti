using ESN_WinForm.Helpers;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ESN_WinForm.Services
{
    public static class ArticleService
    {
        private static readonly string baseURL = "https://localhost:8012/Article/";

        public static async Task<string> GetAllArticles()
        {
            return await HTTPClient.Get(baseURL, "articles");
        }

        public static async Task<string> GetAllArticlesByTitle(string search)
        {
            return await HTTPClient.Get(baseURL, "articles-by-title?title=", search);
        }

        public static async Task<string> Add(ArticleDTO article)
        {
            return await HTTPClient.Post(baseURL, "article", article);
        }
    }
}
