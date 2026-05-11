
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

    public void MoveItem(TodoItem target, TodoItem destination)
    {
        // TODO should you be allowed to move completed children?
        // signs point to no


        // remove from TopLevel
        todoItems.Remove(target);
        // remove from parent
        target.Parent.RemoveChild(target);

        destination.IncompeteChildren.Add(target);
    }
}