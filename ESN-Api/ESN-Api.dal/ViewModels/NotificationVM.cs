using ESN_Api.ESN_Api.dal.Domain;

namespace ESN_Api.ESN_Api.dal.ViewModels
{
    public class NotificationVM
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public bool Read { get; set; }

        public NotificationVM()
        {

        }

        public NotificationVM(int id, Article article, bool read)
        {
            Id = id;
            ArticleId = article.Id;
            Title = article.Title;
            Read = read;
        }
    }
}