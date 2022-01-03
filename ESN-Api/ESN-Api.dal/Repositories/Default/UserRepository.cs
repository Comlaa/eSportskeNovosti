using ESN_Api.ESN_Api.dal.Database;
using ESN_Api.ESN_Api.dal.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ESN_Api.ESN_Api.dal.Repositories.Default
{
    public class UserRepository : IUserRepository
    {
        private readonly ESNDbContext _context;

        public UserRepository(ESNDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserVM>> Get50Users()
        {
            return await _context.Users.Take(50).Select(user => new UserVM(user)).ToListAsync();
        }
    }
}
