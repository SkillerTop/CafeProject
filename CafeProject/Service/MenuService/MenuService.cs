public class MenuService : IMenuService
{
    private List<MenuItem> _menuItems = new List<MenuItem>();

    public MenuService()
    {
        _menuItems.Add(new MenuItem { Id = 1, Name = "Бургер", Price = 100 });
        _menuItems.Add(new MenuItem { Id = 2, Name = "Піца", Price = 150 });
        _menuItems.Add(new MenuItem { Id = 3, Name = "Салат", Price = 80 });
        _menuItems.Add(new MenuItem { Id = 4, Name = "Суп", Price = 70 });
        _menuItems.Add(new MenuItem { Id = 5, Name = "Паста", Price = 120 });
        _menuItems.Add(new MenuItem { Id = 6, Name = "Стейк", Price = 200 });
        _menuItems.Add(new MenuItem { Id = 7, Name = "Риба", Price = 180 });
        _menuItems.Add(new MenuItem { Id = 8, Name = "Сок", Price = 50 });
        _menuItems.Add(new MenuItem { Id = 9, Name = "Кава", Price = 60 });
        _menuItems.Add(new MenuItem { Id = 10, Name = "Чай", Price = 40 });
    }

    public List<MenuItem> GetMenuItems()
    {
        return _menuItems;
    }

    public void AddMenuItem(MenuItem menuItem)
    {
        _menuItems.Add(menuItem);
    }

    public bool UpdateMenuItem(int id, MenuItem menuItem)
    {
        MenuItem existingMenuItem = _menuItems.Find(m => m.Id == id);
        if (existingMenuItem != null)
        {
            existingMenuItem.Name = menuItem.Name;
            existingMenuItem.Price = menuItem.Price;
            return true;
        }
        return false;
    }

    public bool RemoveMenuItem(int id)
    {
        MenuItem menuItemToRemove = _menuItems.Find(m => m.Id == id);
        if (menuItemToRemove != null)
        {
            _menuItems.Remove(menuItemToRemove);
            return true;
        }
        return false;
    }
}
