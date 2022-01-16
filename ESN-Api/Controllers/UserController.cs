using ESN_Api.ESN_Api.dal.DTO;
using ESN_Api.ESN_Api.dal.Repositories;
using ESN_Api.ESN_Api.dal.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ESN_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

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

        [HttpGet("users-by-username")]
        public async Task<List<UserVM>> GetUsersByUsername(string username)
        {
            return await _userRepository.GetUsersByUsername(username);
        }

        [HttpPut("login")]
        public async Task<bool> Login([FromBody] LoginDTO user)
        {
            return await _userRepository.Login(user.Username, user.Password);
        }

        [HttpPost("register")]
        public async Task<bool> Register([FromBody] RegisterDTO account)
        {
            return await _userRepository.Register(account);
        }

    }
}