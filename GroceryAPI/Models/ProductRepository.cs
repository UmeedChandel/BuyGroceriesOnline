using Microsoft.EntityFrameworkCore;

namespace GroceryAPI.Models
{
    public class ProductRepository : IProductRepository
    {
        public readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Product> AllProduct => _appDbContext.Products;
            //.Include(c => c.Category);

        public IEnumerable<Product> ProductOfTheWeek => _appDbContext.Products.Where(product => product.IsProductOfTheWeek);

        public Product GetProductById(int productId)
        {
            return AllProduct.FirstOrDefault(product => product.ProductId == productId);
        }       
    }
}
