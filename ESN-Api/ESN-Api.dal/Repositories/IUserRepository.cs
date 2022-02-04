using ESN_Api.ESN_Api.dal.Domain;
using ESN_Api.ESN_Api.dal.ViewModels;

namespace ESN_Api.ESN_Api.dal.Repositories
{
    public interface IUserRepository
    {
        Task<List<UserVM>> Get50Users();
        Task<UserVM> GetUserById(int userId);
        Task<int> GetUserId(string username);
        Task<List<UserVM>> GetUsersByUsername(string username);
        Task<User> Login(string username, string password);
        Task<bool> Register(RegisterDTO account);
        Task<bool> Edit(UserVM user);
    }
}
