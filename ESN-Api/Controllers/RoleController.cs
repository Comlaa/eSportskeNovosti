using ESN_Api.ESN_Api.dal.Domain;
using ESN_Api.ESN_Api.dal.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ESN_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;

        public RoleController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("role")]
        public async Task<bool> AddRole([FromBody] Role Role)
        {
            return await _roleRepository.AddRole(Role);
        }

        [Authorize(Roles = "Admin, Editor")]
        [HttpGet("roles")]
        public async Task<List<Role>> GetRoles()
        {
            var response = await _roleRepository.Get50Roles();

            return response;
        }

        [Authorize(Roles = "Admin, Editor")]
        [HttpGet("role")]
        public async Task<Role> GetRole(int RoleId)
        {
            return await _roleRepository.GetRoleById(RoleId);
        }

        [Authorize(Roles = "Admin, Editor")]
        [HttpGet("roles-by-name")]
        public async Task<List<Role>> GetRolesByName(string name)
        {
            return await _roleRepository.GetRoleByName(name);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("role")]
        public async Task DeleteCategory(int RoleId)
        {
            await _roleRepository.DeleteRole(RoleId);
        }

        [Authorize(Roles = "Admin, Editor")]
        [HttpPut("role")]
        public async Task EditRole([FromBody] Role role)
        {
            await _roleRepository.EditRole(role);
        }
    }
}
