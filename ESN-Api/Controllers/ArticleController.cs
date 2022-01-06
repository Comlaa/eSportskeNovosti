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
        public async Task<bool> AddArticle([FromBody] ArticleDTO article)
        {
           return await _articleRepository.AddArticle(article); 
        }

        [HttpGet("articles")]
        public async Task<List<ArticleVM>> GetArticles()
        {
            return await _articleRepository.Get50Articles();
        }

        [HttpGet("articles-by-title")]
        public async Task<List<ArticleVM>> GetUsersByUsername(string title)
        {
            return await _articleRepository.GetArticleByTitle(title);
        }
    }
}