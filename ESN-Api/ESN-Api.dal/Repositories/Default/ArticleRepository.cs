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

        public async Task<List<ArticleVM>> Get50Articles()
        {
            return await _context.Articles.Include(a => a.Category)
            .Include(a => a.ArticleComments)
            .Include(a => a.ArticleRatings)
            .Take(50).Select(article =>
            new ArticleVM(article, article.Category.Name,
            article.ArticleComments.Where(a => a.ArticleId == article.Id).Select(c => c.Comment).ToList(),
            article.ArticleRatings.Where(a => a.ArticleId == article.Id).Select(x => x.Rating).DefaultIfEmpty().Average())).ToListAsync();
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
    }
}
