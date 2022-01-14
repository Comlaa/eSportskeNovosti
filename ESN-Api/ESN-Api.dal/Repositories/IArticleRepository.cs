using ESN_Api.ESN_Api.dal.DTO;
using ESN_Api.ESN_Api.dal.ViewModels;

namespace ESN_Api.ESN_Api.dal.Repositories
{
    public interface IArticleRepository
    {
        Task<bool> AddArticle(ArticleDTO article);
        Task DeleteArticle(int articleId);
        Task EditArticle(ArticleDTO article);
        Task<List<ArticleVM>> Get50Articles();
        Task<List<ArticleVM>> GetArticleByTitle(string title);
        Task<ArticleDTO> GetArticleById(int articleId);

    }
}
