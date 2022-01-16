namespace ESN_Api.ESN_Api.dal.DTO
{
    public class ArticleFavoritesDTO
    {
        public int ArticleId { get; set; }
        public int UserId { get; set; }
        public bool Favorite { get; set; }
        public bool Saved { get; set; }
    }
}
