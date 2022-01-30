namespace ESN_Api.ESN_Api.dal.Domain
{
    public class UserRole : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
