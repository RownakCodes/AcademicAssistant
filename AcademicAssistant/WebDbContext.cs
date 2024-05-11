using AcademicAssistant.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademicAssistant
{
    public class WebDbContext :DbContext
    {
        DbSet<Test> Tests { get; set; }

        public WebDbContext(DbContextOptions<WebDbContext> options)
      : base(options)
        {
        }
    }
}
