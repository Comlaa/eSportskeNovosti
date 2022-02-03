using System.Threading.Tasks;

namespace ESN_WinForm.Helpers
{
    public static class Delay
    {
        public static async Task<bool> Wait3seconds()
        {
            await Task.Delay(3000);
            return true;
        }
    }
}
