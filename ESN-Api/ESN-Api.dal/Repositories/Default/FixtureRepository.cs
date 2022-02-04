using ESN_Api.ESN_Api.dal.Database;
using ESN_Api.ESN_Api.dal.Domain;
using ESN_Api.ESN_Api.dal.DTO;
using ESN_Api.ESN_Api.dal.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ESN_Api.ESN_Api.dal.Repositories.Default
{
    public class FixtureRepository : IFixtureRepository
    {
        private readonly ESNDbContext _context;

        public FixtureRepository(ESNDbContext context)
        {
            _context = context;
        }


        public async Task<bool> AddFixture(FixtureDTO fixture)
        {
            await _context.Fixtures.AddAsync(new Fixture(fixture));
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<FixtureVM>> Get50Fixtures()
        {
            return await _context.Fixtures.Include(f => f.Category)
                                          .Select(f => new FixtureVM(f, f.Category.Name))
                                          .Take(50)
                                          .ToListAsync();
        }

        public async Task<FixtureVM> GetFixtureById(int fixtureId)
        {
            var fixture = await _context.Fixtures.Include(f => f.Category)
                                          .Select(f => new FixtureVM(f, f.Category.Name))
                                          .FirstOrDefaultAsync(f => f.Id == fixtureId);

            if (fixture == null)
                throw new Exception("Rezultat ne postoji");

            return fixture;
        }
    }
}
