

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Versta.Data.Models;


namespace Versta.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        { }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("WebApiDatabase");
                
            }
        }
        public DbSet<Order> Orders { get; set; }
    }
}
