public class OrderService : IOrderService
{
    private List<Order> _orders = new List<Order>();

    public OrderService()
    {
        _orders.Add(new Order { Id = 1, TableNumber = 1, Items = new List<MenuItem> { new MenuItem { Id = 1, Name = "Бургер", Price = 100 } } });
        _orders.Add(new Order { Id = 2, TableNumber = 2, Items = new List<MenuItem> { new MenuItem { Id = 2, Name = "Піца", Price = 150 } } });
        // Додаткові замовлення
        _orders.Add(new Order { Id = 3, TableNumber = 3, Items = new List<MenuItem> { new MenuItem { Id = 3, Name = "Салат", Price = 80 } } });
        _orders.Add(new Order { Id = 4, TableNumber = 4, Items = new List<MenuItem> { new MenuItem { Id = 4, Name = "Суп", Price = 70 } } });
        _orders.Add(new Order { Id = 5, TableNumber = 5, Items = new List<MenuItem> { new MenuItem { Id = 5, Name = "Паста", Price = 120 } } });
        _orders.Add(new Order { Id = 6, TableNumber = 6, Items = new List<MenuItem> { new MenuItem { Id = 6, Name = "Стейк", Price = 200 } } });
        _orders.Add(new Order { Id = 7, TableNumber = 7, Items = new List<MenuItem> { new MenuItem { Id = 7, Name = "Риба", Price = 180 } } });
        _orders.Add(new Order { Id = 8, TableNumber = 8, Items = new List<MenuItem> { new MenuItem { Id = 8, Name = "Сок", Price = 50 } } });
        _orders.Add(new Order { Id = 9, TableNumber = 9, Items = new List<MenuItem> { new MenuItem { Id = 9, Name = "Кава", Price = 60 } } });
        _orders.Add(new Order { Id = 10, TableNumber = 10, Items = new List<MenuItem> { new MenuItem { Id = 10, Name = "Чай", Price = 40 } } });
    }

    public List<Order> GetOrders()
    {
        return _orders;
    }

    public void AddOrder(Order order)
    {
        _orders.Add(order);
    }

    public bool UpdateOrder(int id, Order order)
    {
        Order existingOrder = _orders.Find(o => o.Id == id);
        if (existingOrder != null)
        {
            existingOrder.TableNumber = order.TableNumber;
            existingOrder.Items = order.Items;
            return true;
        }
        return false;
    }

    public bool RemoveOrder(int id)
    {
        Order orderToRemove = _orders.Find(o => o.Id == id);
        if (orderToRemove != null)
        {
            _orders.Remove(orderToRemove);
            return true;
        }
        return false;
    }

    public void PlaceOrder(Order order)
    {
        _orders.Add(order);
    }

    public bool CancelOrder(int id)
    {
        Order orderToRemove = _orders.Find(o => o.Id == id);
        if (orderToRemove != null)
        {
            _orders.Remove(orderToRemove);
            return true;
        }
        return false;
    }
}
