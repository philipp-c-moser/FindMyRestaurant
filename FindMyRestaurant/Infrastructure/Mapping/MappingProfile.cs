using AutoMapper;

using FindMyRestaurant.Core.Domain;
using FindMyRestaurant.Core.Dto.Restaurant;

namespace FindMyRestaurant.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Restaurant, RestaurantDto>();

        }
    }
}