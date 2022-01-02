namespace ESN_Api.Domain
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Tags { get; set; }
        public int CategoryId { get; set; }       
        public Category Category { get; set; }
        public List<ArticleComment> ArticleComments { get; set; }
        public List<SavedArticle> SavedArticles { get; set; }
        public List<ArticleRating> ArticleRatings { get; set; }
    }
}
