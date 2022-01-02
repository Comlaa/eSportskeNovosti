﻿namespace ESN_Api.Domain
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public List<UserRole> Roles { get; set; }
        public List<ArticleComment> ArticleComments { get; set; }
        public List<SavedArticle> SavedArticles { get; set; }
        public List<ArticleRating> ArticleRatings { get; set; }
        public string Username { get; set; }       
        public string Email { get; set; }       
    }
}
