using ESN_Api.ESN_Api.dal.DTO;

namespace ESN_Api.ESN_Api.dal.Domain
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

        public Article()
        {

        }

        public Article(ArticleDTO article)
        {
            Title = article.Title;
            Text = article.Text;
            Tags = article.Tags;
            CategoryId = article.CategoryId;
        }
    }
}
