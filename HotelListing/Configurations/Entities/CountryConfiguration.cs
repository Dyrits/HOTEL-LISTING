using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class CountryConfiguration: IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    Id = 1,
                    Name = "United States",
                    Abbreviation = "US"
                },
                new Country
                {
                    Id = 2,
                    Name = "Canada",
                    Abbreviation = "CA"
                },
                new Country
                {
                    Id = 3,
                    Name = "Mexico",
                    Abbreviation = "MX"
                },
                new Country
                {
                    Id = 4,
                    Name = "United Kingdom",
                    Abbreviation = "UK"
                },
                new Country
                {
                    Id = 5,
                    Name = "France",
                    Abbreviation = "FR"
                }
            );
        }
    }
}