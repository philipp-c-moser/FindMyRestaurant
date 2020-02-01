using AutoMapper;

using FindMyRestaurant.Core.Domain;
using FindMyRestaurant.Core.Dto.Restaurant;
using FindMyRestaurant.Core.Dto.Visit;

namespace FindMyRestaurant.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Restaurant, RestaurantDto>();

            CreateMap<Visit, SaveVisitDto>();
            CreateMap<SaveVisitDto, Visit>();

            CreateMap<Restaurant, RestaurantOverviewDto>();

        }
    }
}