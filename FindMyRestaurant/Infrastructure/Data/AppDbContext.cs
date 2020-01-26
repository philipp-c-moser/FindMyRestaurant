using System.Data.Entity;

using FindMyRestaurant.Core.Domain;

namespace FindMyRestaurant.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantCategory> RestaurantCategories { get; set; }



        public AppDbContext()
            : base("name=DefaultConnection")
        {
        }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }

    }
}