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
        public List<ArticleCommentsVM> ArticleComments { get; set; }
        public double ArticleRating { get; set; }
        public string Comments { get; set; }
        public string Picture { get; set; }
        public bool Favorite { get; set; }
        public bool Saved { get; set; }

        public ArticleVM()
        {

        }

        public ArticleVM(Article article, string category, List<ArticleCommentsVM> comments, double rating, bool saved, bool favorite)
        {
            Id = article.Id;
            Title = article.Title;
            Text = article.Text;
            Tags = article.Tags;
            Picture = article.Picture;
            Category = category;
            ArticleComments = comments;
            ArticleRating = rating;
            Comments = article.AllowComments ? "Dozvoljeni" : "Nisu dozvoljeni";
            Saved = saved;
            Favorite = favorite;
        }

        public ArticleVM(Article article, string category, List<ArticleCommentsVM> comments, double rating)
        {
            Id = article.Id;
            Title = article.Title;
            Text = article.Text;
            Tags = article.Tags;
            Picture = article.Picture;
            Category = category;
            ArticleComments = comments;
            ArticleRating = rating;
            Comments = article.AllowComments ? "Dozvoljeni" : "Nisu dozvoljeni";
        }
    }
}
