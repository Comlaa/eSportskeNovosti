namespace ESN_Api.ESN_Api.dal.Domain
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public string Permissions { get; set; }
        public List<UserRole> Users { get; set; }
    }
}
