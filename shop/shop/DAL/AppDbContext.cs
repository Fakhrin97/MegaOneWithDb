using Microsoft.EntityFrameworkCore;
using shop.Models;

namespace shop.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Prodacts> Prodacts { get; set; }
        public DbSet<Arrivals> Arrivals { get; set; }
    }
}
