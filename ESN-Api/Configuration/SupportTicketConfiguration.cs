using ESN_Api.ESN_Api.dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ESN_Api.Configuration
{
    public class SupportTicketConfiguration : BaseEntityConfiguration<SupportTicket>
    {
        public override void Configure(EntityTypeBuilder<SupportTicket> builder)
        {
            base.Configure(builder);

            builder.HasData(new SupportTicket
            {
                Id = 1,
                UserId = 3,
                CreatedAt = new DateTime(2022, 1, 2, 18, 00, 00, DateTimeKind.Utc),
                Email = "korisnik@mail.com",
                Text = "Testiranje funkcionalnosti podrske."
            });
        }
    }
}
