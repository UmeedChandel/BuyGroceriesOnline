using Microsoft.EntityFrameworkCore;

namespace BuyGroceriesOnline.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public IEnumerable<OrderDetail> OrderDetails => _appDbContext.OrderDetails
            .Include(c => c.Order)
            .Include(c => c.Product);

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    ProductId = shoppingCartItem.Product.ProductId,
                    Price = shoppingCartItem.Product.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _appDbContext.Orders.Add(order);

            _appDbContext.SaveChanges();
        }

        public void CancelOrder(OrderDetail order)
        {
            var orders =
                    _appDbContext.OrderDetails.SingleOrDefault(s => s.OrderDetailId == order.OrderDetailId);
            if (orders != null)
            {
                _appDbContext.OrderDetails.Remove(orders);
            }
            _appDbContext.SaveChanges();
        }
    }
}
