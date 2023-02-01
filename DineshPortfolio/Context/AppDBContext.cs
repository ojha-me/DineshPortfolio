using DineshPortfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace DineshPortfolio.Context
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options) {
        
        }
        public DbSet<Blog> Blogs { get; set; }
    }
}
