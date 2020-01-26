using AutoMapper;

using FindMyRestaurant.Core.Domain;
using FindMyRestaurant.Core.Dto;

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