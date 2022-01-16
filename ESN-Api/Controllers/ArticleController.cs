using ESN_Api.ESN_Api.dal.DTO;
using ESN_Api.ESN_Api.dal.Repositories;
using ESN_Api.ESN_Api.dal.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ESN_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

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
    }
}