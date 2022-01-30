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

        [HttpGet("categories")]
        public async Task<List<Category>> GetCategories()
        {
            var response = await _categoryRepository.Get50Categories();

            return response;
        }

        [HttpGet("category")]
        public async Task<Category> GetCategory(int CategoryId)
        {
            return await _categoryRepository.GetCategoryById(CategoryId);
        }

        [HttpGet("categories-by-name")]
        public async Task<List<Category>> GetCategoriesByName(string name)
        {
            return await _categoryRepository.GetCategoryByName(name);
        }

        [HttpDelete("category")]
        public async Task DeleteCategory(int CategoryId)
        {
            await _categoryRepository.DeleteCategory(CategoryId);
        }

        [HttpPut("category")]
        public async Task EditCategory([FromBody] Category category)
        {
            await _categoryRepository.EditCategory(category);
        }
    }
}