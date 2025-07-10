using Microsoft.EntityFrameworkCore;
using MyCrudApp.Models;


namespace MyCrudApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts)
            : base(opts) { }

        public DbSet<Product> Products { get; set; }
    }
}
