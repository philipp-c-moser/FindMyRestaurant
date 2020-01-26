using System.Web.Http;

using FindMyRestaurant.Framework.Controllers;
using FindMyRestaurant.Core;

namespace FindMyRestaurant.WebApi.v1
{
    [RoutePrefix("Api/V1/Restaurants")]
    public class RestaurantsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RestaurantsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
