namespace ESN_Api.ESN_Api.dal.Domain
{
    public class Favourite : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string Tags { get; set; }
    }
}
