namespace ESN_Api.Domain
{
    public class ArticleComment : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public string Comment { get; set; }
        public bool IsApproved { get; set; }
    }
}
