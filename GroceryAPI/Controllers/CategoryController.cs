using GroceryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryAPI.Controllers
{
    [ApiController]
    [Route("Category")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        [Route("AllCategories")]
        public IActionResult AllCategories()
        {
            try
            {
                var AllCategories = _categoryRepository.AllCategories;
                return Ok(AllCategories);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpGet]
        [Route("GetCategory")]
        public ActionResult<IEnumerable<Category>> GetCategory(int categoryId = 1)
        {
            try
            {
                var Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == categoryId);
                return Ok(Category);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }        
    }
}
