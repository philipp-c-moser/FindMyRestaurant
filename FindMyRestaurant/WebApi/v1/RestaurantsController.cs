using AutoMapper;
using System.Web.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

using FindMyRestaurant.Framework.Controllers;
using FindMyRestaurant.Core;
using FindMyRestaurant.Core.Domain;
using FindMyRestaurant.Core.Dto;

namespace FindMyRestaurant.WebApi.v1
{
    [RoutePrefix("api/v1/restaurants")]
    public class RestaurantsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RestaurantsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        

        [Route("getLatest")]
        public async Task<IEnumerable<RestaurantDto>> GetLatest()
        {
            
            var latestRestaurants = await _unitOfWork.RestaurantRepository.GetLatestRestaurantsAsync(_amountOfItemsForQuickTables);

            return Mapper.Map<IEnumerable<Restaurant>, IEnumerable<RestaurantDto>>(latestRestaurants);
        }
    }
}
