using ESN_Api.ESN_Api.dal.Domain;

namespace ESN_Api.ESN_Api.dal.ViewModels
{
    public class FixtureVM
    {
        public int Id { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public string Result { get; set; }
        public string MatchTime { get; set; }
        public string CategoryName { get; set; }

        public FixtureVM()
        {

        }

        public FixtureVM(Fixture fixture, string categoryName)
        {
            Id = fixture.Id;
            Team1 = fixture.Team1;
            Team2 = fixture.Team2;
            Result = fixture.Result;
            CategoryName = categoryName;
            MatchTime = fixture.MatchTime.ToString("dd.MM.yyyy HH:mm");
        }
    }
}
