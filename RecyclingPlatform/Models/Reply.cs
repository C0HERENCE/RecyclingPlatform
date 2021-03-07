using System;

namespace RecyclingPlatform.Models
{
    public class Reply
    {
        public int Id { get; set; }
        public int NewsId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime CreateTime { get; set; }
        public string Content { get; set; }
        public bool Enabled { get; set; }
    }
}