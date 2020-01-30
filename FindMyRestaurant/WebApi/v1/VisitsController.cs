using System.Web.Http;
using System.Threading.Tasks;

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


        [HttpPost]
        [Route("add")]
        public async Task<IHttpActionResult> Add()
        {
            return Ok();
        }

    }
}
