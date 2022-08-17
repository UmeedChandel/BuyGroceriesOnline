using BuyGroceriesOnline.Models;

namespace BuyGroceriesOnline.ViewModels
{
    public class CustomClass
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
        public string CategoryDescription { get; set; }
    }
}
