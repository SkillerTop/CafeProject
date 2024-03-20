public class MenuService : IMenuService
{
    private List<MenuItem> _menuItems = new List<MenuItem>();

    public MenuService()
    {
        _menuItems.Add(new MenuItem { Id = 1, Name = "������", Price = 100 });
        _menuItems.Add(new MenuItem { Id = 2, Name = "ϳ��", Price = 150 });
        _menuItems.Add(new MenuItem { Id = 3, Name = "�����", Price = 80 });
        _menuItems.Add(new MenuItem { Id = 4, Name = "���", Price = 70 });
        _menuItems.Add(new MenuItem { Id = 5, Name = "�����", Price = 120 });
        _menuItems.Add(new MenuItem { Id = 6, Name = "�����", Price = 200 });
        _menuItems.Add(new MenuItem { Id = 7, Name = "����", Price = 180 });
        _menuItems.Add(new MenuItem { Id = 8, Name = "���", Price = 50 });
        _menuItems.Add(new MenuItem { Id = 9, Name = "����", Price = 60 });
        _menuItems.Add(new MenuItem { Id = 10, Name = "���", Price = 40 });
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
