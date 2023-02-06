using System.Collections.Generic;

namespace HotelListing.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        
        /*
         * FOREIGN ENTITIES
         */
        
        public virtual IList<Hotel> Hotels { get; set; }
    }
}