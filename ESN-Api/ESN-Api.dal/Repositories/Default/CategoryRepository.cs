using ESN_Api.ESN_Api.dal.Database;
using ESN_Api.ESN_Api.dal.Domain;
using Microsoft.EntityFrameworkCore;

namespace ESN_Api.ESN_Api.dal.Repositories.Default
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ESNDbContext _context;

        public CategoryRepository(ESNDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddCategory(Category category)
        {
            await _context.Categories.AddAsync(category);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task DeleteCategory(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }

        public async Task EditCategory(Category _category)
        {
            var category = await _context.Categories.FindAsync(_category.Id);
            if (category != null)
            {
                category.Name = _category.Name;
                category.Description = _category.Description;

                _context.Categories.Update(category);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Category>> Get50Categories()
        {
            return await _context.Categories.Take(50).ToListAsync();
        }

        public async Task<Category> GetCategoryById(int categoryId)
        {
            return await _context.Categories.FindAsync(categoryId);
        }

        public async Task<List<Category>> GetCategoryByName(string name)
        {
            return await _context.Categories.Where(c => c.Name.Contains(name)).Take(50).ToListAsync();
        }
    }
}
