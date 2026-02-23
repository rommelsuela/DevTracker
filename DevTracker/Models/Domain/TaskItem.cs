namespace DevTracker.Models.Domain
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
