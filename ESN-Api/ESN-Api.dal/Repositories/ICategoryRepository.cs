using ESN_Api.ESN_Api.dal.Domain;

namespace ESN_Api.ESN_Api.dal.Repositories
{
    public interface ICategoryRepository
    {
        Task<bool> AddCategory(Category category);
        Task DeleteCategory(int categoryId);
        Task EditCategory(Category category);
        Task<List<Category>> Get50Categories();
        Task<List<Category>> GetCategoryByName(string name);
        Task<Category> GetCategoryById(int categoryId);

    }
}
