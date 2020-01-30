using AutoMapper;
using System.Web.Http;

using FindMyRestaurant.Framework.Controllers;
using FindMyRestaurant.Core;
using FindMyRestaurant.Core.Domain;
using FindMyRestaurant.Core.Dto.Visit;

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
        public IHttpActionResult Add([FromBody] SaveVisitDto saveVisitDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Not valid");
            }

            var visit = Mapper.Map<SaveVisitDto, Visit>(saveVisitDto);

            _unitOfWork.VisitRepository.Add(visit);


            return Ok();
        }

    }
}
