﻿using ESN_Api.ESN_Api.dal.Database;
using ESN_Api.ESN_Api.dal.Domain;
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

        public async Task<bool> Edit(UserVM newUser)
        {
            var oldUser = await _context.Users.FindAsync(newUser.Id);

            if (oldUser != null)
            {
                oldUser.Email = newUser.Email;
                oldUser.Username = newUser.Username;
                oldUser.FirstName = newUser.Name;

                _context.Users.Update(oldUser);
                await _context.SaveChangesAsync();
            }

            return true;
        }

        public async Task<List<UserVM>> Get50Users()
        {
            return await _context.Users.Take(50).Select(user => new UserVM(user)).ToListAsync();
        }

        public async Task<UserVM> GetUserById(int userId)
        {
            return await _context.Users.Where(u => u.Id == userId).Select(user => new UserVM(user)).FirstOrDefaultAsync();
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

        public async Task<bool> Register(RegisterDTO account)
        {
            byte[] pwSalt = PasswordHelper.GetSalt();
            string pwHash = PasswordHelper.GetHash(account.Password, pwSalt);
            _context.Users.Add(new User
            {
                Email = account.Email,
                Username = account.Username,
                FirstName = account.Firstname,
                Lastname = account.Lastname,
                GenderId = account.GenderId,
                PasswordHash = pwHash,
                PasswordSalt = Convert.ToBase64String(pwSalt),
            });

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
