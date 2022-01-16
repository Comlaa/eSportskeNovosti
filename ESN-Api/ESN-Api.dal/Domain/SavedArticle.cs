namespace ESN_Api.ESN_Api.dal.Domain
{
    public class SavedArticle : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public SavedArticle()
        {

        }

        public SavedArticle(int userId, int articleId)
        {
            UserId = userId;
            ArticleId = articleId;
        }
    }
}
