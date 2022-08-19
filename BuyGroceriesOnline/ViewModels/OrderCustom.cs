using BuyGroceriesOnline.Models;

namespace BuyGroceriesOnline.ViewModels
{
    public class OrderCustom
    {
        public IEnumerable<Product> Products { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
