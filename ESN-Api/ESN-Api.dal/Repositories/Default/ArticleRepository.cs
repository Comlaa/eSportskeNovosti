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

        public async Task<List<ArticleVM>> GetArticleByTitle(string title)
        {
            

            return await _context.Articles.Where(a => a.Title.Contains(title)).Include(a => a.Category)
            .Include(a => a.ArticleComments)
            .Include(a => a.ArticleRatings)
            .Take(50).Select(article =>
            new ArticleVM(article, article.Category.Name,
            article.ArticleComments.Where(a => a.ArticleId == article.Id).Select(c => c.Comment).ToList(),
            article.ArticleRatings.Where(a => a.ArticleId == article.Id).Select(x => x.Rating).DefaultIfEmpty().Average())).ToListAsync();
        }
    }
}
