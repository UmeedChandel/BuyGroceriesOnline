using BuyGroceriesOnline.Models;
using BuyGroceriesOnline.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            return _productRepository.AllProduct;
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

        // Crud Operations

        public void CategoryItem()
        {
            var categories = _categoryRepository.AllCategories;
            List<SelectListItem> categoryItems = new List<SelectListItem>();
            foreach (var category in categories)
            {
                categoryItems.Add(new SelectListItem { Text = category.CategoryName, Value = category.CategoryId.ToString() });
            }
            ViewBag.categoryItems = categoryItems;
        }

        public ViewResult Create()
        {
            CategoryItem();
            return View();
        }

        [HttpPost]
        public IActionResult InsertItem(Product product)
        {
            _productRepository.InsertProduct(product);
            return RedirectToAction("List");
        }

        public ViewResult Edit(int id)
        {
            CategoryItem();
            var product = GetAllProduct().FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        [HttpPut]
        public IActionResult UpdateItem(Product product)
        {
            _productRepository.UpdateProduct(product);
            return RedirectToAction("List");
        }

        public ViewResult Delete(int id)
        {
            var product = GetAllProduct().FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        [HttpDelete]
        public IActionResult DeleteItem(int productId)
        {
            _productRepository.DeleteProduct(productId);
            return RedirectToAction("List");
        }

    }
}
