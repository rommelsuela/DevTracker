namespace DevTracker.Models.Domain
{
    public class ActivityLog
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public DateTime Timestamp { get; set; }
        public string UserName { get; set; }
    }
}
