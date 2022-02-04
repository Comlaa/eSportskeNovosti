using ESN_Api.ESN_Api.dal.DTO;
using ESN_Api.ESN_Api.dal.Repositories;
using ESN_Api.ESN_Api.dal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ESN_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IRecommendationRepository _recommendationRepository;

        public ArticleController(IArticleRepository articleRepository, IRecommendationRepository recommendationRepository)
        {
            _articleRepository = articleRepository;
            _recommendationRepository = recommendationRepository;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("article")]
        public async Task<string> AddArticle([FromBody] ArticleDTO article)
        {
            await _articleRepository.AddArticle(article);
            return "success";
        }

        [HttpGet("articles")]
        public async Task<List<ArticleVM>> GetArticles(int userId)
        {
            return await _articleRepository.Get50Articles(userId);
        }

        [HttpGet("favorite-articles")]
        public async Task<List<ArticleVM>> GetFavoriteArticles(int userId)
        {
            return await _articleRepository.Get50FavoritesArticles(userId);
        }

        [HttpGet("saved-articles")]
        public async Task<List<ArticleVM>> GetSavedArticles(int userId)
        {
            return await _articleRepository.Get50SavedArticles(userId);
        }

        [HttpGet("article")]
        public async Task<ArticleDTO> GetArticle(int articleId)
        {
            return await _articleRepository.GetArticleById(articleId);
        }

        [HttpGet("articles-by-title")]
        public async Task<List<ArticleVM>> GetUsersByUsername(string title)
        {
            return await _articleRepository.GetArticleByTitle(title);
        }

        [HttpDelete("article")]
        public async Task DeleteArticle(int articleId)
        {
            await _articleRepository.DeleteArticle(articleId);
        }

        [Authorize(Roles = "Admin, Editor")]
        [HttpPut("article")]
        public async Task EditArticle([FromBody] ArticleDTO newArticle)
        {
            await _articleRepository.EditArticle(newArticle);
        }

        [HttpPut("article-favorites")]
        public async Task UpdateFavorites([FromBody] ArticleFavoritesDTO updatedArticle)
        {
            await _articleRepository.UpdateArticleFavorite(updatedArticle);
        }

        [HttpGet("recommended-articles")]
        public List<ArticleVM> Recommend(int userId)
        {
            return _recommendationRepository.GetRecommendedArticles(userId);
        }

        [HttpPut("article-comment")]
        public async Task AddComment([FromBody] CommentDTO comment)
        {
            await _articleRepository.AddComment(comment);
        }

        [HttpPut("article-rating")]
        public async Task AddRating([FromBody] RatingDTO rating)
        {
            await _articleRepository.AddRating(rating);
        }

        [HttpGet("comments")]
        public async Task<List<ArticleCommentsVM>> GetComments(int userId)
        {
            return await _articleRepository.GetComments(userId);
        }
    }
}