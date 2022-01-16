using ESN_Api.ESN_Api.dal.Database;
using ESN_Api.ESN_Api.dal.Domain;
using ESN_Api.ESN_Api.dal.DTO;
using ESN_Api.ESN_Api.dal.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ESN_Api.ESN_Api.dal.Repositories.Default
{
    public class ArticleRepository : IArticleRepository
    {

        private readonly ESNDbContext _context;

        public ArticleRepository(ESNDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddArticle(ArticleDTO article)
        {
            await _context.Articles.AddAsync(new Article(article));
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task DeleteArticle(int articleId)
        {
            var article = await _context.Articles.FindAsync(articleId);
            if (article != null)
            {
                _context.Articles.Remove(article);
                await _context.SaveChangesAsync();
            }
        }

        public async Task EditArticle(ArticleDTO _article)
        {
            var article = await _context.Articles.FindAsync(_article.Id);
            if (article != null)
            {
                article.Title = _article.Title;
                article.Text = _article.Text;
                article.AllowComments = _article.AllowComments;
                article.Tags = _article.Tags;
                article.Date = _article.Date;
                article.CategoryId = _article.CategoryId;
                article.Picture = _article.Picture;

                _context.Update(article);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<ArticleVM>> Get50Articles(int userId)
        {
            var tags = _context.Favourites.Where(f => f.UserId == userId).Select(f => f.Tags).ToList();
            return await _context.Articles.Include(a => a.Category)
            .Include(a => a.ArticleComments)
            .Include(a => a.ArticleRatings)
            .Include(a => a.SavedArticles)
            .Take(50).Select(article =>
            new ArticleVM(article, article.Category.Name,
            article.ArticleComments.Where(a => a.ArticleId == article.Id).Select(c => c.Comment).ToList(),
            Math.Round(article.ArticleRatings.Where(a => a.ArticleId == article.Id).Select(x => x.Rating).DefaultIfEmpty().Average(), 2),
            article.SavedArticles.Any(a => a.ArticleId == article.Id && a.UserId == userId),
            tags.Contains(article.Tags))).ToListAsync();
        }

        public async Task<List<ArticleVM>> Get50FavoritesArticles(int userId)
        {
            var tags = _context.Favourites.Where(f => f.UserId == userId).Select(f => f.Tags).ToList();
            return await _context.Articles.Include(a => a.Category)
            .Include(a => a.ArticleComments)
            .Include(a => a.ArticleRatings)
            .Include(a => a.SavedArticles)
            .Where(a => tags.Contains(a.Tags))
            .Take(50).Select(article =>
            new ArticleVM(article, article.Category.Name,
            article.ArticleComments.Where(a => a.ArticleId == article.Id).Select(c => c.Comment).ToList(),
            Math.Round(article.ArticleRatings.Where(a => a.ArticleId == article.Id).Select(x => x.Rating).DefaultIfEmpty().Average(), 2),
            article.SavedArticles.Any(a => a.ArticleId == article.Id && a.UserId == userId), true)).ToListAsync();
        }

        public async Task<List<ArticleVM>> Get50SavedArticles(int userId)
        {
            var lista = await _context.SavedArticles.Include(sa => sa.Article).Where(sa => sa.UserId == userId).Select(sa => sa.Article.Id).ToListAsync();
            var tags = _context.Favourites.Where(f => f.UserId == userId).Select(f => f.Tags).ToList();

            return await _context.Articles.Include(a => a.Category)
            .Include(a => a.ArticleComments)
            .Include(a => a.ArticleRatings)
            .Include(a => a.SavedArticles)
            .Where(a => lista.Contains(a.Id))
            .Take(50).Select(article =>
            new ArticleVM(article, article.Category.Name,
            article.ArticleComments.Where(a => a.ArticleId == article.Id).Select(c => c.Comment).ToList(),
            Math.Round(article.ArticleRatings.Where(a => a.ArticleId == article.Id).Select(x => x.Rating).DefaultIfEmpty().Average(), 2),
            true, tags.Contains(article.Tags))).ToListAsync();
        }

        public async Task<ArticleDTO> GetArticleById(int articleId)
        {
            return await _context.Articles.Where(a => a.Id == articleId).Select(article => new ArticleDTO(article)).FirstOrDefaultAsync();
        }

        public async Task<List<ArticleVM>> GetArticleByTitle(string title)
        {

            return await _context.Articles.Where(a => a.Title.Contains(title))
            .Include(a => a.Category)
            .Include(a => a.ArticleComments)
            .Include(a => a.ArticleRatings)
            .Take(50).Select(article =>
            new ArticleVM(article, article.Category.Name,
            article.ArticleComments.Where(a => a.ArticleId == article.Id).Select(c => c.Comment).ToList(),
            article.ArticleRatings.Where(a => a.ArticleId == article.Id).Select(x => x.Rating).DefaultIfEmpty().Average())).ToListAsync();
        }

        public async Task UpdateArticleFavorite(ArticleFavoritesDTO article)
        {
            var savedArticle = await _context.SavedArticles.FirstOrDefaultAsync(sa => sa.ArticleId == article.ArticleId);
            if (savedArticle == null)
            {
                if (article.Saved)
                {
                    _context.SavedArticles.Add(new SavedArticle(article.UserId, article.ArticleId));
                }
            }
            else
            {
                if (!article.Saved)
                {
                    _context.SavedArticles.Remove(savedArticle);
                }
            }

            var user = await _context.Favourites.FirstOrDefaultAsync(u => u.UserId == article.UserId);
            var _article = await _context.Articles.FindAsync(article.ArticleId);
            if (user == null && article.Favorite)
            {
                _context.Favourites.Add(new Favourite
                {
                    UserId = article.UserId,
                    Tags = _article.Tags,
                });
            }

            if (user != null)
            {
                if (article.Favorite)
                {
                    user.Tags = _article.Tags;
                    _context.Favourites.Update(user);
                }
                else
                {
                    _context.Favourites.Remove(user);
                }
            }

            _context.SaveChanges();
        }
    }
}
