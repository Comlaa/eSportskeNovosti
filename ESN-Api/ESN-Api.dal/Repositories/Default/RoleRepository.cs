using ESN_Api.ESN_Api.dal.Database;
using ESN_Api.ESN_Api.dal.Domain;
using Microsoft.EntityFrameworkCore;

namespace ESN_Api.ESN_Api.dal.Repositories.Default
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ESNDbContext _context;
        public RoleRepository(ESNDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddRole(Role role)
        {
            await _context.Roles.AddAsync(role);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task DeleteRole(int roleId)
        {
            var role = await _context.Roles.FindAsync(roleId);
            if (role != null)
            {
                _context.Roles.Remove(role);
                await _context.SaveChangesAsync();
            }
        }

        public async Task EditRole(Role _role)
        {
            var role = await _context.Roles.FindAsync(_role.Id);
            if (role != null)
            {
                role.Name = _role.Name;
                role.Permissions = _role.Permissions;

                _context.Roles.Update(role);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Role>> Get50Roles()
        {
            return await _context.Roles.Take(50).ToListAsync();
        }

        public async Task<Role> GetRoleById(int roleId)
        {
            return await _context.Roles.FindAsync(roleId);
        }

        public async Task<List<Role>> GetRoleByName(string name)
        {
            return await _context.Roles.Where(c => c.Name.Contains(name)).Take(50).ToListAsync();
        }
    }
}
