namespace PostsAndTasksConsoleApp
{
    public class Task : HasId<int>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
    }
}
