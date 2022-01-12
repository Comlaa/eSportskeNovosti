using ESN_Api.ESN_Api.dal.Domain;
using ESN_Api.ESN_Api.dal.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ESN_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpPost("category")]
        public async Task<string> AddCategory([FromBody] Category Category)
        {
            await _categoryRepository.AddCategory(Category);
            return "success";
        }

        [HttpGet("Categories")]
        public async Task<List<Category>> GetCategorys()
        {
            return await _categoryRepository.Get50Categories();
        }

        [HttpGet("Category")]
        public async Task<Category> GetCategory(int CategoryId)
        {
            return await _categoryRepository.GetCategoryById(CategoryId);
        }

        [HttpGet("Categories-by-name")]
        public async Task<List<Category>> GetCategoriesByName(string name)
        {
            return await _categoryRepository.GetCategoryByName(name);
        }

        [HttpDelete("Category")]
        public async Task DeleteCategory(int CategoryId)
        {
            await _categoryRepository.DeleteCategory(CategoryId);
        }

        [HttpPut("Category")]
        public async Task EditCategory([FromBody] Category category)
        {
            await _categoryRepository.EditCategory(category);
        }
    }
}