using ESN_Api.ESN_Api.dal.DTO;
using ESN_Api.ESN_Api.dal.Repositories;
using ESN_Api.ESN_Api.dal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ESN_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [Authorize(Roles = "Admin, Editor")]
        [HttpGet("users")]
        public async Task<List<UserVM>> GetUsers()
        {
            return await _userRepository.Get50Users();
        }

        [HttpGet("user-id")]
        public async Task<int> GetUserId(string username)
        {
            return await _userRepository.GetUserId(username);
        }

        [Authorize(Roles = "Admin, Editor")]
        [HttpGet("users-by-username")]
        public async Task<List<UserVM>> GetUsersByUsername(string username)
        {
            return await _userRepository.GetUsersByUsername(username);
        }

        [HttpPut("login")]
        public async Task<bool> Login([FromBody] LoginDTO user)
        {
            var loginResponse = await _userRepository.Login(user.Username, user.Password);
            return loginResponse != null;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<bool> Register([FromBody] RegisterDTO account)
        {
            return await _userRepository.Register(account);
        }

        [HttpGet("user")]
        public async Task<UserVM> GetUser(int userId)
        {
            return await _userRepository.GetUserById(userId);
        }

        [Authorize(Roles = "Admin, Editor")]
        [HttpPut("user")]
        public async Task<bool> EditUser(UserVM user)
        {
            return await _userRepository.Edit(user);
        }

    }
}