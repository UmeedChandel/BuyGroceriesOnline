namespace BuyGroceriesOnline.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        void CancelOrder(OrderDetail order);
        IEnumerable<OrderDetail> OrderDetails { get; }
    }
}
