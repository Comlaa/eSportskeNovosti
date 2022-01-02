namespace ESN_Api.Domain
{
    public class Favourite : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string Tags { get; set; }
    }
}
