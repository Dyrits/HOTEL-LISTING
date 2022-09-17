using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base (options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
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
            builder.Entity<Hotel>().HasData(
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

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
    }
}