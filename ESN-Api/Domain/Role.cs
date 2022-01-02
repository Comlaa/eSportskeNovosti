namespace ESN_Api.Domain
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public string Permissions { get; set; }
        public List<UserRole> Users { get; set; }
    }
}
