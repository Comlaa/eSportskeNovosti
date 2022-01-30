using ESN_Api.ESN_Api.dal.ViewModels;

namespace ESN_Api.ESN_Api.dal.Repositories
{
    public interface IRecommendationRepository
    {
        List<ArticleVM> GetRecommendedArticles(int userId);
    }
}
