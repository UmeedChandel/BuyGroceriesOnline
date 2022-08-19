namespace GroceryAPI.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProduct { get; }
        IEnumerable<Product> ProductOfTheWeek { get; }
        Product GetProductById(int productId);

        
    }
}
