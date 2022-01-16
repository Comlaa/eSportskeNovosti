using ESN_Api.ESN_Api.dal.Database;
using ESN_Api.ESN_Api.dal.Domain;
using ESN_Api.ESN_Api.dal.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ESN_Api.ESN_Api.dal.Repositories.Default
{
    public class RecommendationRepository : IRecommendationRepository
    {

        private readonly ESNDbContext _context;

        public RecommendationRepository(ESNDbContext context)
        {
            _context = context;
        }

        readonly Dictionary<int, List<ArticleRating>> articles = new();

        public List<ArticleVM> GetRecommendedArticles(int userId)
        {
            return LoadSimilar(userId);
        }

        private List<ArticleVM> LoadSimilar(int userId)
        {
            List<ArticleRating> ratingOfCurrent = _context.ArticleRatings.Where(ar => ar.UserId == userId).OrderBy(ar => ar.ArticleId).ToList();
            LoadOtherArticles(userId, ratingOfCurrent.Where(a => a.Rating > 4).Select(a => a.ArticleId).FirstOrDefault());
            List<ArticleRating> ratings1 = new();
            List<ArticleRating> ratings2 = new();
            List<ArticleVM> recommendedArticles = new();

            foreach (var article in articles)
            {
                foreach (ArticleRating rating in ratingOfCurrent)
                {
                    if (article.Value.Where(a => a.ArticleId != rating.ArticleId).Any())
                    {
                        ratings1.Add(rating);
                        ratings2.Add(article.Value.Where(a => a.UserId != userId).First());
                    }
                }
                double similarity = GetSimilarity(ratings1, ratings2);
                if (similarity > 0.5)
                {
                    var tags = _context.Favourites.Where(f => f.UserId == userId).Select(f => f.Tags).ToList();
                    var _article = _context.Articles.Include(a => a.Category)
                    .Include(a => a.ArticleComments)
                    .Include(a => a.ArticleRatings)
                    .Include(a => a.SavedArticles)
                    .Where(a => a.Id == article.Key)
                    .Take(50).Select(article =>
                    new ArticleVM(article, article.Category.Name,
                    article.ArticleComments.Where(a => a.ArticleId == article.Id).Select(c => c.Comment).ToList(),
                    Math.Round(article.ArticleRatings.Where(a => a.ArticleId == article.Id).Select(x => x.Rating).DefaultIfEmpty().Average(), 2),
                    article.SavedArticles.Any(a => a.ArticleId == article.Id && a.UserId == userId),
                    tags.Contains(article.Tags))).FirstOrDefault();

                    if (_article != null)
                        recommendedArticles.Add(_article);
                }
                ratings1.Clear();
                ratings2.Clear();
            }
            return recommendedArticles;
        }

        private static double GetSimilarity(List<ArticleRating> ratings1, List<ArticleRating> ratings2)
        {
            if (ratings1.Count != ratings2.Count)
            {
                return 0;
            }
            double x = 0, y1 = 0, y2 = 0;
            for (int i = 0; i < ratings1.Count; i++)
            {
                x += ratings1[i].Rating * ratings2[i].Rating;
                y1 += ratings1[i].Rating * ratings1[i].Rating;
                y2 += ratings2[i].Rating * ratings2[i].Rating;
            }
            y1 = Math.Sqrt(y1);
            y2 = Math.Sqrt(y2);

            double y = y1 * y2;
            if (y == 0)
                return 0;
            return x / y;
        }

        private void LoadOtherArticles(int userId, int articleId)
        {
            var notReviewed = _context.ArticleRatings.Where(ar => ar.UserId != userId && ar.ArticleId != articleId).Select(ar => ar.ArticleId).ToList();
            List<Article> articleList = _context.Articles.Where(a => notReviewed.Contains(a.Id)).ToList();
            List<ArticleRating> ratings = new();
            foreach (var _article in articleList)
            {
                ratings = _context.ArticleRatings.Where(ar => ar.ArticleId == _article.Id).OrderBy(ar => ar.ArticleId).ToList();
                if (ratings.Any())
                {
                    articles.Add(_article.Id, ratings);
                }
            }
        }
    }

}
