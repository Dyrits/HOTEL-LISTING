using AutoMapper;
using HotelListing.Data;
using HotelListing.Models.Country;
using HotelListing.Models.Hotel;

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
        }
    }
}