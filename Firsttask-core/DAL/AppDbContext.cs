using Firsttask_core.Models;
using Microsoft.EntityFrameworkCore;

namespace Firsttask_core.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {        
        }

      public  DbSet<Faq> Faqs { get; set; }

    }
}
