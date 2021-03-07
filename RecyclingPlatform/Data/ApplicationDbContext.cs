using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecyclingPlatform.Models;

namespace RecyclingPlatform.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Reply> Replies { get; set; }

        public DbSet<ActivityUser> ActivityUsers { get; set; }
    }
}