using FindMyRestaurant.Core.Domain;
using FindMyRestaurant.Core.Repositories;
using FindMyRestaurant.Infrastructure.Data;

namespace FindMyRestaurant.Infrastructure.Repositories
{
    public class RestaurantCategoryRepository : Repository<RestaurantCategory>, IRestaurantCategoryRepository
    {
        public RestaurantCategoryRepository(AppDbContext context)
            : base(context)
        {
        }

    }
}