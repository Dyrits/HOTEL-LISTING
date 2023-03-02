using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models.User
{
    public class UserDTO: UserLogin
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}