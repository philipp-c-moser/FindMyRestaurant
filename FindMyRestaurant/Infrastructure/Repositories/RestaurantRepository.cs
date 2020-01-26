using FindMyRestaurant.Core.Domain;
using FindMyRestaurant.Core.Repositories;
using FindMyRestaurant.Infrastructure.Data;

namespace FindMyRestaurant.Infrastructure.Repositories
{
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(AppDbContext context)
            : base(context)
        {
        }

    }
}