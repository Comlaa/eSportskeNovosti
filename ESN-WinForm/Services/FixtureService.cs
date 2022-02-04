using ESN_WinForm.Helpers;
using System.Threading.Tasks;

namespace ESN_WinForm.Services
{
    public class FixtureService
    {
        private static readonly string baseURL = "http://localhost:8012/Fixture/";

        public static async Task<string> GetFixtures()
        {
            return await HTTPClient.Get(baseURL, "fixtures");
        }

        public static async Task<string> GetFixture(int fixtureId)
        {
            return await HTTPClient.Get(baseURL, "fixture?fixtureId=", fixtureId);
        }

        public static async Task<string> Add(FixtureDTO fixture)
        {
            return await HTTPClient.Post(baseURL, "fixture", fixture);
        }
    }
}
