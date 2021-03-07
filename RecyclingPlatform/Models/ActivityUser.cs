namespace RecyclingPlatform.Models
{
    public class ActivityUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
        public User User { get; set; }
        public bool Enabled { get; set; }
    }
}