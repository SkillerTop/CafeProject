public class Order
{
    public int Id { get; set; }
    public int TableNumber { get; set; }
    public List<MenuItem> Items { get; set; }
}