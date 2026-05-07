
namespace Habitual
{
    // TODO save to file, load from file

    public class ListProvider
    {
        private Dictionary<string, TodoList> todoLists = [];
        private List<TodoItem> todoItems = [];

        public static ListProvider GetListProvider()
        {
            _provider ??= new();
            return _provider;
        }
        private static ListProvider _provider = null;

        public Dictionary<string, TodoList> GetAllLists()
        {
            return todoLists;
        }

        public List<TodoItem> GetAllItems()
        {
            return todoItems;
        }

        public TodoList GetList(string key)
        {
            // TODO double check this
            if (!todoLists.TryGetValue(key, out TodoList? value))
            {
                value = new() { Title = key };
                todoLists[key] = value;
            }
            return value;
        }

        public bool RemoveList(string key)
        {
            return todoLists.Remove(key);
        }

        public void AddList(string key, TodoList list)
        {
            todoLists.Add(key, list);
        }

        public void AddTopLevel(TodoItem list)
        {
            todoItems.Add(list);
        }
    }
}