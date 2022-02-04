using ESN_Api.ESN_Api.dal.DTO;
using ESN_Api.ESN_Api.dal.ViewModels;

namespace ESN_Api.ESN_Api.dal.Repositories
{
    public interface IFixtureRepository
    {
        Task<bool> AddFixture(FixtureDTO fixture);
        Task<List<FixtureVM>> Get50Fixtures();
        Task<FixtureVM> GetFixtureById(int fixtureId);
    }
}
