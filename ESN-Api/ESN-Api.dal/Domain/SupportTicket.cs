using ESN_Api.ESN_Api.dal.ViewModels;

namespace ESN_Api.ESN_Api.dal.Domain
{
    public class SupportTicket : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }

        public SupportTicket()
        {

        }

        public SupportTicket(TicketVM ticket)
        {
            UserId = ticket.UserId;
            Email = ticket.Email;
            Text = ticket.Text;
        }
    }
}
