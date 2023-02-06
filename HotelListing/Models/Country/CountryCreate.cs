using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models.Country
{
    public class CountryCreate
    {
        // In fact, with 56 characters, the "United Kingdom of Great Britain and Northern Ireland" has the honor of being the longest country name in the world.
        [Required, StringLength(maximumLength: 56, ErrorMessage = "The name of the country must be less or equals to 56 characters.")]
        public string Name { get; set; }
        
        [Required, StringLength(maximumLength: 2, ErrorMessage = "The abbreviation of the country must be less or equal to 2 characters.")]
        public string Abbreviation { get; set; }
    }
}