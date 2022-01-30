using System;

namespace ESN_WinForm.Services
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
        public string Picture { get; set; }

        public ArticleDTO()
        {

        }

        public ArticleDTO(string title, string text, string tags, DateTime date, bool comments, int categoryId, string picture)
        {
            Title = title;
            Text = text;
            Tags = tags;
            Date = date;
            AllowComments = comments;
            CategoryId = categoryId;
            Picture = picture;
        }
    }
}