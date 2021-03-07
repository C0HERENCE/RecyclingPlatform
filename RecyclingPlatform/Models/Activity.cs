using System;
using System.Collections.Generic;
using System.Linq;

namespace RecyclingPlatform.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime EndTime { get; set; }
        public string ActiveTime { get; set; }
        public IEnumerable<ActivityUser> Users { get; set; }
    }
}