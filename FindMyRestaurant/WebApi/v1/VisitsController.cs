using System.Web.Http;

using FindMyRestaurant.Framework.Controllers;
using FindMyRestaurant.Core;

namespace FindMyRestaurant.WebApi.v1
{
    [RoutePrefix("api/v1/visits")]
    public class VisitsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public VisitsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
