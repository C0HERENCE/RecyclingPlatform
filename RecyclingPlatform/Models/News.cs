﻿using System;
using System.Collections.Generic;

namespace RecyclingPlatform.Models
{
    public class News
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public DateTime CreateTime { get; set; }
        
        public string Title { get; set; }
        public string Content { get; set; }

        public IEnumerable<Reply> Replies { get; set; }
    }
}