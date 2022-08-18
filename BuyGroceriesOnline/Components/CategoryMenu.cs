using BuyGroceriesOnline.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuyGroceriesOnline.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke() 
        {
            return View(_categoryRepository.AllCategories);
        }
    }
}
