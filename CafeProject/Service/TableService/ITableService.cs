public interface ITableService
{
    List<Table> GetTables();
    void AddTable(Table table);
    bool RemoveTable(int number);
}
