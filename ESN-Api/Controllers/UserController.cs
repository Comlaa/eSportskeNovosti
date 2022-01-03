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

        [HttpPut("login")]
        public async Task<bool> Login([FromBody] LoginVM user)
        {
            return await _userRepository.Login(user.Username, user.Password);
        }
    }
}