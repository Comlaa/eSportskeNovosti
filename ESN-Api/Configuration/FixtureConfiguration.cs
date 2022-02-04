using ESN_Api.ESN_Api.dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ESN_Api.Configuration
{
    public class FixtureConfiguration : BaseEntityConfiguration<Fixture>
    {
        public override void Configure(EntityTypeBuilder<Fixture> builder)
        {
            base.Configure(builder);

            builder.HasData(new Fixture
            {
                Id = 1,
                Team1 = "Barcelona",
                Team2 = "Real Madrid",
                Result = "2:1",
                CategoryId = 1,
                MatchTime = new DateTime(2022, 2, 4, 21, 00, 00, DateTimeKind.Utc),
                CreatedAt = new DateTime(2022, 2, 4, 18, 00, 00, DateTimeKind.Utc),
            });
        }
    }
}
