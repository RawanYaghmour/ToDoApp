namespace ToDoApp.Models
{
    public class TaskItem
    {
        public int Id { get; set; } // Auto-incremented ID
        public string Title { get; set; } // Task title
        public bool IsCompleted { get; set; } = false; // Default value is false
    }

}
