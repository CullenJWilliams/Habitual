namespace Habitual
{
    public class TodoItem
    {
        public string? Title { get; set; }
        public bool Completed
        {
            get
            {
                return CompletedOn <= DateTime.Now;
            }
            set
            {
                if (CompletedOn is null)
                    CompletedOn = DateTime.Now;
                else
                    CompletedOn = null;
            }
        }

        public DateTime? CompletedOn { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        // TODO make this class 
        public string Renew { get; set; }
        public string Notes { get; set; }
        public DateTime Reminder { get; set; }

        public List<TodoItem> IncompeteChildren {get;set;} = [];
        public List<TodoItem> CompleteChildren {get;set;} = [];
        public List<TodoItem> FailedChildren {get;set;} = [];
    }
}