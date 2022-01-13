﻿using ESN_Api.ESN_Api.dal.Domain;

namespace ESN_Api.ESN_Api.dal.ViewModels
{
    public class ArticleVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Tags { get; set; }
        public string Category { get; set; }
        public List<string> ArticleComments { get; set; }
        public double ArticleRating { get; set; }
        public string Comments { get; set; }

        public ArticleVM()
        {

        }

        public ArticleVM(Article article, string category, List<string> comments, double rating)
        {
            Id = article.Id;
            Title = article.Title;
            Text = article.Text;
            Tags = article.Tags;
            Category = category;
            ArticleComments = comments;
            ArticleRating = rating;
            Comments = article.AllowComments ? "Dozvoljeni" : "Nisu dozvoljeni";
        }
    }
}