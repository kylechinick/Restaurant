using Microsoft.EntityFrameworkCore;

namespace Restaurant.Models
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }

        public RestaurantContext(DbContextOptions options) :
            base(options)
        {
        }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder
        )
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
