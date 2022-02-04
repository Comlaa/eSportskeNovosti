using ESN_Api.ESN_Api.dal.DTO;
using ESN_Api.ESN_Api.dal.Repositories;
using ESN_Api.ESN_Api.dal.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ESN_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FixtureController : ControllerBase
    {
        private readonly IFixtureRepository _fixtureRepository;

        public FixtureController(IFixtureRepository fixtureRepository)
        {
            _fixtureRepository = fixtureRepository;
        }

        [HttpPost("fixture")]
        public async Task<bool> AddFixture([FromBody] FixtureDTO fixture)
        {
            return await _fixtureRepository.AddFixture(fixture);
        }

        [HttpGet("fixtures")]
        public async Task<List<FixtureVM>> GetFixtures()
        {
            return await _fixtureRepository.Get50Fixtures();
        }

        [HttpGet("fixture")]
        public async Task<FixtureVM> GetFixtureById(int fixtureId)
        {
            return await _fixtureRepository.GetFixtureById(fixtureId);
        }
    }
}