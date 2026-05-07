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
        public DateTime CreatedOn {get;set;} = DateTime.Now;
    }
}