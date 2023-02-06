using System.Collections.Generic;
using HotelListing.Models.Hotel;

namespace HotelListing.Models.Country
{
    public class CountryDTO : CountryCreate
    {
        public int Id { get; set; }
        
        public IList<HotelDTO> Hotels { get; set; }
    }
}