using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models.Hotel
{
    public class HotelCreate
    {
        // The longest hotel name in the world is "The Taum Sauk Mountain Electric Power Generating Station Inn" located in Missouri, USA.
        [Required, StringLength(maximumLength: 56, ErrorMessage = "The name of the hotel must be less or equal to 56 characters.")]
        public string Name { get; set; }
        
        // The longest address in the world is not officially recognized, but one of the longest known addresses is in New Zealand, which has approximately 158 characters.
        [Required, StringLength(maximumLength: 158, ErrorMessage = "The address of the hotel must be less or equal to 158 characters.")]
        public string Address { get; set; }
        
        [Required, Range(1, 5, ErrorMessage = "The rating of the hotel must be between 1 and 5.")]
        public double Rating { get; set; }
        
        [Required]
        public int CountryId { get; set; }
    }
}