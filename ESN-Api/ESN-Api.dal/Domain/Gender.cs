namespace ESN_Api.ESN_Api.dal.Domain
{
    public class Gender : BaseEntity
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
