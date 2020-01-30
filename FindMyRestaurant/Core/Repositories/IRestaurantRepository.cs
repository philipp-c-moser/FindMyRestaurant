using System.Collections.Generic;
using System.Threading.Tasks;

using FindMyRestaurant.Core.Domain;


namespace FindMyRestaurant.Core.Repositories
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        Task<IList<Restaurant>> GetRestaurantsAlphabeticalAsync(int amount);
        Task<IList<Restaurant>> GetLatestRestaurantsAsync(int amount);
    }
}
