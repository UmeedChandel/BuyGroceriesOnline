namespace BuyGroceriesOnline.Models
{
    public class ProductRepository : IProductRepository
    {
        public readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Product> AllProduct => _appDbContext.Products;

        public IEnumerable<Product> ProductOfTheWeek => _appDbContext.Products.Where(product => product.IsProductOfTheWeek);

        public Product GetProductById(int productId)
        {
            return AllProduct.FirstOrDefault(product => product.ProductId == productId);
        }

        public Product DeleteProduct(int productId)
        {
            var product = GetProductById(productId);
            var entry = _appDbContext.Products.Remove(product);
            _appDbContext.SaveChanges();
            return entry.Entity;
        }

        public Product InsertProduct(Product products)
        {
            var entry = _appDbContext.Products.Add(products);
            _appDbContext.SaveChanges();
            return entry.Entity;
        }

        public Product UpdateProduct(Product products)
        {
            var entry = _appDbContext.Products.Update(products);
            _appDbContext.SaveChanges();
            return entry.Entity;
        }
    }
}
