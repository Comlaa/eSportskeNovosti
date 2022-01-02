namespace ESN_Api.Domain
{
    public class ArticleRating : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public int Rating { get; set; }
    }
}
