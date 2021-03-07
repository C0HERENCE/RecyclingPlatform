using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace RecyclingPlatform.Models
{
    public class User : IdentityUser<int>
    {
        public IEnumerable<Activity> Activities { get; set; }
        public IEnumerable<Reply> Replies { get; set; }
    }
}