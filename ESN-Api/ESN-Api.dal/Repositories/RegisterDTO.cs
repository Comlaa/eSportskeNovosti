namespace ESN_Api.ESN_Api.dal.Repositories
{
    public class RegisterDTO
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int GenderId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}