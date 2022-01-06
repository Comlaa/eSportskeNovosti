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
    }
}
