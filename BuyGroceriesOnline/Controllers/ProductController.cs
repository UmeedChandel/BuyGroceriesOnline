using BuyGroceriesOnline.Models;
using BuyGroceriesOnline.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BuyGroceriesOnline.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        private IEnumerable<Product> GetAllProduct()
        {
            var products = _productRepository.AllProduct ;
            return products;
        }

        public IActionResult List(int id)
        {
            IEnumerable<Product> product;
            CustomClass customClass = new CustomClass();
            if (id > 0)
            {
                product = GetAllProduct().Where(p => p.CategoryId == id);
                customClass.CurrentCategory = product.FirstOrDefault().Category.CategoryName;
                customClass.CategoryDescription = product.FirstOrDefault().Category.Description ;
            }
            else
            {
                product = GetAllProduct();
                customClass.CurrentCategory = "List Of Products";
                customClass.CategoryDescription = "";
            }

            customClass.Products = product;
            return View(customClass);
        }

        public IActionResult ProductOfWeek()
        {
            return View(_productRepository.ProductOfTheWeek);
        }


        public IActionResult Details(int id)
        {
            return View(GetAllProduct().FirstOrDefault(p => p.ProductId == id));
        }
    }
}
