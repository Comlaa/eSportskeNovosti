using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace ESN_WinForm.Helpers
{
    public static class HTTPClient
    {
        public static async Task<string> Get(string baseUrl, string endpoint, string parameters = null)
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
        
        public static async Task<bool> Put(string baseUrl, string endpoint, object data)
        {
            using (HttpClient client = new HttpClient())
            {
                return await BaseHttpClient(client.PutAsJsonAsync(baseUrl + endpoint, data));
            }
        }

        public static async Task<bool> Post(string baseUrl, string endpoint, object data)
        {
            using (HttpClient client = new HttpClient())
            {
                return await BaseHttpClient(client.PostAsJsonAsync(baseUrl + endpoint, data));
            }
        }

        private static async Task<bool> BaseHttpClient(Task<HttpResponseMessage> request)
        {
            using (HttpResponseMessage response = await request)
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
