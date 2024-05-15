using AcademicAssistant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcademicAssistant
{
    public class WebDbContext :DbContext
    {
        public DbSet<Test> Tests { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }



        public WebDbContext(DbContextOptions<WebDbContext> options)
      : base(options)
        {
        }
    }
}
