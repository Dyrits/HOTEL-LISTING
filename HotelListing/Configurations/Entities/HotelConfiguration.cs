using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Hotel One",
                    Address = "123 Main Street",
                    CountryId = 5,
                    Rating = 3.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hotel Two",
                    Address = "456 Main Street",
                    CountryId = 4,
                    Rating = 4
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Hotel Three",
                    Address = "789 Main Street",
                    CountryId = 3,
                    Rating = 3.5
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Hotel Four",
                    Address = "1011 Main Street",
                    CountryId = 2,
                    Rating = 5
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Hotel Five",
                    Address = "1213 Main Street",
                    CountryId = 1,
                    Rating = 5.5
                }
            );
        }
    }
}