using AutoMapper;
using HotelListing.Data;
using HotelListing.Models.Country;
using HotelListing.Models.Hotel;
using HotelListing.Models.User;

namespace HotelListing.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            // Country~
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CountryCreate>().ReverseMap();

            // Hotel~
            CreateMap<Hotel, HotelDTO>().ReverseMap();
            CreateMap<Hotel, HotelCreate>().ReverseMap();
            
            // User~
            CreateMap<User, UserDTO>()
                .ForMember(DTO => DTO.Email, options => options.MapFrom(user => user.UserName))
                .ReverseMap();
            CreateMap<User, UserLogin>().ReverseMap();
        }
    }
}