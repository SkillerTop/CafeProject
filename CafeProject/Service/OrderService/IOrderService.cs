public interface IOrderService
{
    List<Order> GetOrders();
    void PlaceOrder(Order order);
    bool CancelOrder(int id);
    void AddOrder(Order order);
    bool UpdateOrder(int id, Order order);
    bool RemoveOrder(int id);
}
