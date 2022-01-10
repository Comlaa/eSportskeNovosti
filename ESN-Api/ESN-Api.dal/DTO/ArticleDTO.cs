namespace ESN_Api.ESN_Api.dal.DTO
{
    public class ArticleDTO
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Tags { get; set; }
        public DateTime Date { get; set; }
        public bool AllowComments { get; set; }
        public int CategoryId { get; set; }
    }
}
