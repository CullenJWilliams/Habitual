public class TodoList
{

    public List<TodoItem> Items {get; set;} = [];
    public string? Title {get;set;}
    public bool Completed {get;set;}
}