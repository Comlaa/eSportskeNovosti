using ESN_Api.ESN_Api.dal.Database;
using ESN_Api.ESN_Api.dal.Helpers;
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

        public async Task<int> GetUserId(string username)
        {
            var user = await _context.Users.FirstOrDefaultAsync(user => user.Email == username || user.Username == username);
            if (user != null)
                return user.Id;

            return 0;
        }

        public async Task<List<UserVM>> GetUsersByUsername(string username)
        {
            return await _context.Users.Where(x => x.Username.Contains(username)).Select(user => new UserVM(user)).ToListAsync();
        }

        public async Task<bool> Login(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(user => user.Username.Equals(username));
            if (user != null)
            {
                var passwordSalt = Convert.FromBase64String(user.PasswordSalt);
                return user.PasswordHash == PasswordHelper.GetHash(password, passwordSalt);
            }

            return false;
        }
    }
}
