using Microsoft.AspNetCore.Mvc;

namespace BuyGroceriesOnline.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
