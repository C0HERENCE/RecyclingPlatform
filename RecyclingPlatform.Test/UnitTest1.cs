using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using RecyclingPlatform.Data;
using RecyclingPlatform.Models;

namespace RecyclingPlatform.Test
{
    public class Tests
    {
        private ApplicationDbContext _dbContext;
        
        [SetUp]
        public void Setup()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseSqlite(@"Data Source = C:\Users\Yang\Desktop\Projects\RecyclingPlatform\RecyclingPlatform\app.db");
            _dbContext = new ApplicationDbContext(builder.Options);
        }
        
        [Test]
        public void Test1()
        {
            foreach (var user in _dbContext.Users.ToList())
            {
                Console.WriteLine(user.UserName);
            }
        }

        [Test]
        public void Test2()
        {
            foreach (var news in _dbContext.News.ToList())
            {
                Console.WriteLine(news.Id);
                Console.WriteLine(news.Title);
                Console.WriteLine(news.Content);
            }
        }

        [Test]
        public void Test3()
        {
            var news = new News
            {
                AuthorId = 1,
                Content = "新闻内容123",
                CreateTime = DateTime.Now,
                Title = "新闻4"
            };
            _dbContext.News.Add(news);
            _dbContext.SaveChanges();
        }
    }
}