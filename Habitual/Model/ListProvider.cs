
namespace Habitual;
// TODO save to file, load from file

public class ListProvider
{
    private readonly List<TodoItem> todoItems = [];

    public static ListProvider GetListProvider()
    {
        _provider ??= new();
        return _provider;
    }

    private static ListProvider? _provider = null;

    public List<TodoItem> GetAllItems()
    {
        return todoItems;
    }

    public void AddTopLevel(TodoItem list)
    {
        todoItems.Add(list);
    }
}