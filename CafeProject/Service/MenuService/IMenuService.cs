public interface IMenuService
{
    List<MenuItem> GetMenuItems();
    void AddMenuItem(MenuItem menuItem);
    bool UpdateMenuItem(int id, MenuItem menuItem);
    bool RemoveMenuItem(int id);
}