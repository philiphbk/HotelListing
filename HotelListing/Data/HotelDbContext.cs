using HotelListing.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListingHotelDbContext
{
    public class HotelDbContext: DbContext

    {
        public HotelDbContext(DbContextOptions options) : base(options){}

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 2,
                    Name = "Bahama",
                    ShortName = "BS"
                },
                new Country
                {
                    Id = 3,
                    Name = "Coyman Island",
                    ShortName = "CI"
                }
            );
            
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandels Resort and Spa",
                    Address = "Nagril",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort Suites",
                    Address = "George Town",
                    CountryId = 2,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Palidium",
                    Address = "Nassua",
                    CountryId = 3,
                    Rating = 4.0
                }
            );
        }

    }
}