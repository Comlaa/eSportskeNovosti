using ESN_Api.ESN_Api.dal.ViewModels;

namespace ESN_Api.ESN_Api.dal.Repositories
{
    public interface IUserRepository
    {
        Task<List<UserVM>> Get50Users();
    }
}
