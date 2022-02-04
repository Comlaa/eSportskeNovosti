using ESN_Api.ESN_Api.dal.DTO;

namespace ESN_Api.ESN_Api.dal.Domain
{
    public class Fixture : BaseEntity
    {
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public string Result { get; set; }
        public DateTime MatchTime { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Fixture()
        {

        }

        public Fixture(FixtureDTO fixture)
        {
            Team1 = fixture.Team1;
            Team2 = fixture.Team2;
            Result = fixture.Result;
            CategoryId = fixture.CategoryId;
            MatchTime = DateTime.Now;
        }
    }
}
