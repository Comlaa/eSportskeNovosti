using ESN_WinForm.Helpers;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace ESN_WinForm.Services
{
    public class ArticleService
    {
        private static readonly string baseURL = "https://localhost:8012/Article/";

        //public static async Task<string> GetAllArticles()
        //{

        //    return await _httpClient.Get(baseURL, "articles");
        //}

        public static async Task<string> GetAllArticlesByTitle(string search)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(baseURL + "articles-by-title?title=" + search))
                {
                    using (HttpContent content = response.Content)
                    {
                        return await content.ReadAsStringAsync() ?? "No data!";
                    }
                }
            }
        }
        
        public static async Task<bool> Add(ArticleDTO article)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsJsonAsync(baseURL + "article", article))
                {
                    using (HttpContent content = response.Content)
                    {
                        var Loginresponse = await content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<bool>(Loginresponse);
                    }
                }
            }
        }
    }
}
