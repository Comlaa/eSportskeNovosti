using ESN_Api.ESN_Api.dal.Domain;
using ESN_Api.ESN_Api.dal.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ESN_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;

        public RoleController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        [HttpPost("role")]
        public async Task<string> AddRole([FromBody] Role Role)
        {
            await _roleRepository.AddRole(Role);
            return "success";
        }

        [HttpGet("roles")]
        public async Task<List<Role>> GetRoles()
        {
            var response = await _roleRepository.Get50Roles();

            return response;
        }

        [HttpGet("role")]
        public async Task<Role> GetRole(int RoleId)
        {
            return await _roleRepository.GetRoleById(RoleId);
        }

        [HttpGet("roles-by-name")]
        public async Task<List<Role>> GetRolesByName(string name)
        {
            return await _roleRepository.GetRoleByName(name);
        }

        [HttpDelete("role")]
        public async Task DeleteCategory(int RoleId)
        {
            await _roleRepository.DeleteRole(RoleId);
        }

        [HttpPut("role")]
        public async Task EditRole([FromBody] Role role)
        {
            await _roleRepository.EditRole(role);
        }
    }
}
