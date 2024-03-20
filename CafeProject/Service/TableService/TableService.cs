public class TableService : ITableService
{
    private List<Table> _tables = new List<Table>();

    public TableService()
    {
        // Додавання записів для імітації роботи з базою даних
        _tables.Add(new Table { Number = 1, Capacity = 4, IsOccupied = false });
        _tables.Add(new Table { Number = 2, Capacity = 6, IsOccupied = true });
        _tables.Add(new Table { Number = 3, Capacity = 2, IsOccupied = false });
        _tables.Add(new Table { Number = 4, Capacity = 8, IsOccupied = false });
        _tables.Add(new Table { Number = 5, Capacity = 4, IsOccupied = true });
        _tables.Add(new Table { Number = 6, Capacity = 4, IsOccupied = false });
        _tables.Add(new Table { Number = 7, Capacity = 6, IsOccupied = false });
        _tables.Add(new Table { Number = 8, Capacity = 2, IsOccupied = false });
        _tables.Add(new Table { Number = 9, Capacity = 4, IsOccupied = true });
        _tables.Add(new Table { Number = 10, Capacity = 6, IsOccupied = false });
    }

    public List<Table> GetTables()
    {
        return _tables;
    }

    public void AddTable(Table table)
    {
        _tables.Add(table);
    }

    public bool UpdateTable(int number, Table table)
    {
        Table existingTable = _tables.Find(t => t.Number == number);
        if (existingTable != null)
        {
            existingTable.Capacity = table.Capacity;
            existingTable.IsOccupied = table.IsOccupied;
            return true;
        }
        return false;
    }

    public bool RemoveTable(int number)
    {
        Table tableToRemove = _tables.Find(t => t.Number == number);
        if (tableToRemove != null)
        {
            _tables.Remove(tableToRemove);
            return true;
        }
        return false;
    }
}
