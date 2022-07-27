using Microsoft.EntityFrameworkCore;

namespace Restaurant.Models
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Cuisine> Cuisines { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

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
