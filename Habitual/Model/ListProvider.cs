
namespace Habitual;

// TODO save to file, load from file

public class ListProvider
{
    private readonly TodoItem todoItems = new();

    public static ListProvider GetListProvider()
    {
        _provider ??= new();
        return _provider;
    }

    private static ListProvider? _provider = null;

    public TodoItem GetRoot()
    {
        return todoItems;
    }

    public void AddTopLevel(TodoItem list)
    {
        todoItems.IncompeteChildren.Add(list);
    }

    public void MoveItem(TodoItem target, TodoItem destination)
    {
        // TODO should you be allowed to move completed children?
        // signs point to no


        // remove from TopLevel
        // remove from parent
        target.Parent.RemoveChild(target);

        destination.IncompeteChildren.Add(target);
    }
}