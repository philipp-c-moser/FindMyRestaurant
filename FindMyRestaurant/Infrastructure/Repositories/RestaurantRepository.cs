using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

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


        public async Task<IList<Restaurant>> GetRestaurantsAlphabeticalAsync(int amount)
        {
            return await Set.OrderBy(r => r.Name).Take(amount).ToListAsync();
        }

        public async Task<IList<Restaurant>> GetLatestRestaurantsAsync(int amount)
        {
            return await Set.OrderByDescending(r => r.Id).Take(amount).ToListAsync();
        }

    }
}