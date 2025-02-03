namespace TodoAPI.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }

    public static class TodoData
    {
        public static List<TodoItem> Items = new List<TodoItem>
        {
            new TodoItem { Id = 1, Name = "Quiz #1", IsComplete = true },
            new TodoItem { Id = 2, Name = "Assignment #1", IsComplete = false },
            new TodoItem { Id = 3, Name = "Quiz #2", IsComplete = false }
        };
    }
}
