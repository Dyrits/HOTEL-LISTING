using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models.User
{
    public class UserLogin
    {
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}