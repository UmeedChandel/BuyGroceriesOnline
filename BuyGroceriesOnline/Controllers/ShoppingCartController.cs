using BuyGroceriesOnline.Models;
using BuyGroceriesOnline.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace BuyGroceriesOnline.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICouponRepository _couponRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IProductRepository productRepository, ShoppingCart shoppingCart, ICouponRepository couponRepository)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
            _couponRepository = couponRepository;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public ViewResult ApplyCoupon()
        {
            return View();
        }

        public RedirectToActionResult CalculateDiscount(string name)
        {
            var discount = _couponRepository.AllCoupon.Where(n => n.CouponName == name).Select(a => a.Discount).FirstOrDefault();
            var Amount = discount * 0.01;
            decimal Total = _shoppingCart.GetShoppingCartTotal();
            decimal SubTotal = Decimal.Multiply(Total, Convert.ToDecimal(Amount));
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart, 
                ShoppingCartTotal = Total-SubTotal
            };

            return RedirectToAction("Index");
        }

        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var selectedProduct = _productRepository.AllProduct.FirstOrDefault(p => p.ProductId == productId);

            if (selectedProduct != null)
            {
                _shoppingCart.AddToCart(selectedProduct, 1);
            }
            TempData["success"] = "Item Added to Cart";
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            var selectedProduct = _productRepository.AllProduct.FirstOrDefault(p => p.ProductId == productId);

            if (selectedProduct != null)
            {
                _shoppingCart.RemoveFromCart(selectedProduct);
            }
            return RedirectToAction("Index");
        
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveItem(int productId)
        {
            var selectedProduct = _productRepository.AllProduct.FirstOrDefault(p => p.ProductId == productId);
            if (selectedProduct != null)
            {
                _shoppingCart.RemoveItem(selectedProduct);
            }
            return RedirectToAction("Index");
        }
    }
}
