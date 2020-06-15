using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Contexts
{
    public class HolidayHomesOwnersContext : DbContext
    {
        public DbSet<HolidayHomesOwner> HolidayHomesOwners { get; set; }
        public DbSet<HolidayHome> HolidayHomes { get; set; }

        public HolidayHomesOwnersContext(DbContextOptions<HolidayHomesOwnersContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HolidayHomesOwner>().HasData(
                new HolidayHomesOwner
                {
                    Id = 1,
                    FirstName = "Fabricio",
                    LastName = "Vallasciani",
                    Email = "fabriciosvallasciani@hotmail.com",
                    Telephone = "+549341678888"
                });

            modelBuilder.Entity<HolidayHomesOwner>().HasData(
                new HolidayHomesOwner
                {
                    Id = 2,
                    FirstName = "Susana",
                    LastName = "Marcos",
                    Email = "susanabmarcos@hotmail.com",
                    Telephone = "+54934933079"

                });

            modelBuilder.Entity<HolidayHomesOwner>().HasData(
                new HolidayHomesOwner
                {
                    Id = 3,
                    FirstName = "Peter",
                    LastName = "Petrelli",
                    Email = "peterpetrelli@hotmail.com",
                    Telephone = "+44760608930"
                });

            modelBuilder.Entity<HolidayHome>().HasData(
                new HolidayHome
                {
                    Bathrooms = 2,
                    Bedrooms = 3,
                    Description = "Santa Fe 1291",
                    DistanceToAirport = 12,
                    DistanceToBeach = 60,
                    DistanceToShopping = 2,
                    GardenArea = 70,
                    HasBalcony = false,
                    HasPatio = true,
                    HasWiFi = true,
                    Id = 1,
                    LivingArea = 20,
                    OwnerId = 1,
                    Sleeps = 5,
                    TerraceArea = 0
                });

            modelBuilder.Entity<HolidayHome>().HasData(
                new HolidayHome
                {
                    Bathrooms = 3,
                    Bedrooms = 4,
                    Description = "Avenida Siempre Viva 1234",
                    DistanceToAirport = 15,
                    DistanceToBeach = 10,
                    DistanceToShopping = 3,
                    GardenArea = 50,
                    HasBalcony = true,
                    HasPatio = true,
                    HasWiFi = true,
                    Id = 2,
                    LivingArea = 40,
                    OwnerId = 1,
                    Sleeps = 4,
                    TerraceArea = 30
                });

            modelBuilder.Entity<HolidayHome>().HasData(
                new HolidayHome
                {
                    Bathrooms = 1,
                    Bedrooms = 5,
                    Description = "Calle Salamanca 13",
                    DistanceToAirport = 50,
                    DistanceToBeach = 70,
                    DistanceToShopping = 8,
                    GardenArea = 0,
                    HasBalcony = true,
                    HasPatio = false,
                    HasWiFi = true,
                    Id = 3,
                    LivingArea = 10,
                    OwnerId = 1,
                    Sleeps = 5,
                    TerraceArea = 10
                });

            modelBuilder.Entity<HolidayHomeImage>().HasData(
                new HolidayHomeImage
                {
                    Id = 1,
                    Description = "1",
                    Url = "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/55424/9700320-55424-L%27Estartit-Apartment_Crop_450_337.jpg",
                    HolidayHomeId = 1
                });

            modelBuilder.Entity<HolidayHomeImage>().HasData(
                new HolidayHomeImage
                {
                    Id = 2,
                    Description = "2",
                    Url = "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/55424/9700325-55424-L'Estartit-Apartment_Crop_450_337.jpg",
                    HolidayHomeId = 1
                });

            modelBuilder.Entity<HolidayHomeImage>().HasData(
                new HolidayHomeImage
                {
                    Id = 3,
                    Description = "3",
                    Url = "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/55424/9700326-55424-L'Estartit-Apartment_Crop_450_337.jpg",
                    HolidayHomeId = 1
                });

            modelBuilder.Entity<HolidayHomeImage>().HasData(
               new HolidayHomeImage
               {
                   Id = 4,
                   Description = "4",
                   Url = "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/30984/5704854-30984-Roses-Apartment_Crop_450_337.jpg",
                   HolidayHomeId = 2
               });

            modelBuilder.Entity<HolidayHomeImage>().HasData(
                new HolidayHomeImage
                {
                    Id = 5,
                    Description = "5",
                    Url = "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/30984/5807028-30984-Roses-Apartment_Crop_450_337.jpg",
                    HolidayHomeId = 2
                });

            modelBuilder.Entity<HolidayHomeImage>().HasData(
                new HolidayHomeImage
                {
                    Id = 6,
                    Description = "6",
                    Url = "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/30984/5798711-30984-Roses-Apartment_Crop_450_337.jpg",
                    HolidayHomeId = 2
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
