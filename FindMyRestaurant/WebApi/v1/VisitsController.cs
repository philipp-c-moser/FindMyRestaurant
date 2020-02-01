using AutoMapper;
using System.Web.Http;

using FindMyRestaurant.Framework.Controllers;
using FindMyRestaurant.Core;
using FindMyRestaurant.Core.Domain;
using FindMyRestaurant.Core.Dto.Visit;
using System.Threading.Tasks;
using System.Collections.Generic;

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

        [Route("getAllForOverview")]
        public async Task<IEnumerable<VisitOverviewDto>> GetAllForOverviewAsync()
        {
            var allVisits = await _unitOfWork.VisitRepository.GetSortedDescByCreationAsync(_secureMaxAmountOfItemsForRequests);
            var visitOverviewDto = new List<VisitOverviewDto>();

            foreach(var visit in allVisits)
            {
                visitOverviewDto.Add(new VisitOverviewDto
                {
                    Id = visit.Id,
                    VisitName = visit.Name,
                    RestaurantName = _unitOfWork.RestaurantRepository.FindById(visit.RestaurantId).Name
                });
            }


            return visitOverviewDto;
        }


        [HttpPost]
        [Route("add")]
        public async Task<IHttpActionResult> Add([FromBody] SaveVisitDto saveVisitDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Not valid");
            }

            var visit = Mapper.Map<SaveVisitDto, Visit>(saveVisitDto);

            visit.Restaurant = await _unitOfWork.RestaurantRepository.FindByIdAsync(saveVisitDto.Restaurant_Id);


            _unitOfWork.VisitRepository.Add(visit);

            _unitOfWork.SaveChanges();


            return Ok();
        }


        [Route("getAmount")]
        public async Task<int> GetAmount()
        {
            return await _unitOfWork.VisitRepository.CountAsync();
        }

    }
}
