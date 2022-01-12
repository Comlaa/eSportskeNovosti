using System.Net.Http;
using System.Threading.Tasks;

namespace ESN_WinForm.Helpers
{
    public static class HTTPClient
    {
        public static async Task<string> Get(string baseUrl, string endpoint, object parameters = null)
        {
            var url = parameters == null ? baseUrl + endpoint : baseUrl + endpoint + parameters;
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        return await content.ReadAsStringAsync() ?? "No data!";
                    }
                }
            }
        }

        public static async Task<string> Put(string baseUrl, string endpoint, object data)
        {
            using (HttpClient client = new HttpClient())
            {
                return await BaseHttpClient(client.PutAsJsonAsync(baseUrl + endpoint, data));
            }
        }

        public static async Task<string> Post(string baseUrl, string endpoint, object data)
        {
            using (HttpClient client = new HttpClient())
            {
                return await BaseHttpClient(client.PostAsJsonAsync(baseUrl + endpoint, data));
            }
        }

        public static async Task Delete(string baseUrl, string endpoint, int parameter)
        {
            using (HttpClient client = new HttpClient())
            {
                await client.DeleteAsync(baseUrl + endpoint + parameter);
            }
        }

        private static async Task<string> BaseHttpClient(Task<HttpResponseMessage> request)
        {
            using (HttpResponseMessage response = await request)
            {
                using (HttpContent content = response.Content)
                {
                    return await content.ReadAsStringAsync();
                }
            }
        }
    }
}
