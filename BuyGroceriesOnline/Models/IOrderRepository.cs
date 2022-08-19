namespace BuyGroceriesOnline.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        IEnumerable<OrderDetail> OrderDetails { get; }
    }
}
