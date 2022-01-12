using ESN_Api.ESN_Api.dal.Domain;

namespace ESN_Api.ESN_Api.dal.DTO
{
    public class ArticleDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Tags { get; set; }
        public DateTime Date { get; set; }
        public bool AllowComments { get; set; }
        public int CategoryId { get; set; }

        public ArticleDTO()
        {

        }

        public ArticleDTO(Article article)
        {
            Id = article.Id;
            Title = article.Title;
            Text = article.Text;
            Tags = article.Tags;
            CategoryId = article.CategoryId;
            Date = article.Date;
            AllowComments = article.AllowComments;
        }
    }
}
