namespace ESN_Api.Domain
{
    public class Gender : BaseEntity
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
