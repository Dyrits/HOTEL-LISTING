using HotelListing.Models.Country;

namespace HotelListing.Models.Hotel
{
    public class HotelDTO : HotelCreate
    {
        public int Id { get; set; }
        
        public CountryDTO Country { get; set; }
    }
}