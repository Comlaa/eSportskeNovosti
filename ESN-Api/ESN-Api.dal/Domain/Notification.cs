﻿namespace ESN_Api.ESN_Api.dal.Domain
{
    public class Notification : BaseEntity
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public DateTime NotificationDate { get; set; }

        public Notification()
        {

        }

        public Notification(int articleId)
        {
            ArticleId = articleId;
            NotificationDate = DateTime.Now;
            CreatedAt = DateTime.Now;
        }
    }
}
