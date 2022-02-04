using ESN_Api.ESN_Api.dal.Domain;

namespace ESN_Api.ESN_Api.dal.ViewModels
{
    public class TicketVM
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }

        public TicketVM()
        {

        }

        public TicketVM(User user, SupportTicket ticket)
        {
            Id = ticket.Id;
            UserId = user.Id;
            Name = user.FirstName + user.Lastname;
            Email = ticket.Email;
            Text = ticket.Text;
        }
    }
}
