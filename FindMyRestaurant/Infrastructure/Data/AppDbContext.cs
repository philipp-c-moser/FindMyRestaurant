using System.Data.Entity;

using FindMyRestaurant.Core.Domain;
using FindMyRestaurant.Core.Domain.Rating;

namespace FindMyRestaurant.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantCategory> RestaurantCategories { get; set; }
        public DbSet<Visit> Visits { get; set; }


        /* Rating */
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<RatingCriteria> RatingCriterias { get; set; }
        public DbSet<RatedRatingCriteria> RatedRatingCriterias { get; set; }
        /* ./Rating */


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