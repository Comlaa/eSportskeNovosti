using ESN_Api.ESN_Api.dal.ViewModels;

namespace ESN_Api.ESN_Api.dal.Repositories
{
    public interface IUserRepository
    {
        Task<List<UserVM>> Get50Users();
        Task<int> GetUserId(string username);
        Task<List<UserVM>> GetUsersByUsername(string username);
        Task<bool> Login(string username, string password);
        Task<bool> Register(RegisterDTO account);
    }
}
