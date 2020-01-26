using System.Data.Entity;

namespace FindMyRestaurant.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {


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