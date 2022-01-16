using ESN_Api.ESN_Api.dal.Domain;

namespace ESN_Api.ESN_Api.dal.Repositories
{
    public interface IRoleRepository
    {
        Task<bool> AddRole(Role role);
        Task DeleteRole(int roleId);
        Task EditRole(Role role);
        Task<List<Role>> Get50Roles();
        Task<List<Role>> GetRoleByName(string name);
        Task<Role> GetRoleById(int roleId);
    }
}
