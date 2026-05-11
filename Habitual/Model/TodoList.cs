namespace Habitual
{
    public class TodoList
    {

        public List<TodoItem> Items { get; set; } = [];
        public string? Title { get; set; }
        
        /// <summary>
        /// TODO The idea here is that when you complete an item, it should "move" to a different list.
        /// e.g. grocery list -> complete "flour" -> flour shows up on pantry list
        /// then cross off flour from pantry, and it should show up on groceries 
        /// the question is: should that item stay on the original list, and create a duplicate on the new list
        /// or
        /// have some sort of completion history, and physically move the todo item? I think the first
        /// a rule that implies however is that you can never actually delete items, just remove them from view
        /// </summary>
        public string OnCompletionAction { get; set; }
    }
}