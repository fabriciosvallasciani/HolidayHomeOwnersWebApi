﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories.Contexts;

namespace Repositories.Migrations.HolidayHomesOwners
{
    [DbContext(typeof(HolidayHomesOwnersContext))]
    partial class HolidayHomesOwnersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.HolidayHome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Bathrooms")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Bedrooms")
                        .HasColumnType("tinyint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("DistanceToAirport")
                        .HasColumnType("tinyint");

                    b.Property<byte>("DistanceToBeach")
                        .HasColumnType("tinyint");

                    b.Property<byte>("DistanceToShopping")
                        .HasColumnType("tinyint");

                    b.Property<long>("GardenArea")
                        .HasColumnType("bigint");

                    b.Property<bool>("HasBalcony")
                        .HasColumnType("bit");

                    b.Property<bool>("HasPatio")
                        .HasColumnType("bit");

                    b.Property<bool>("HasWiFi")
                        .HasColumnType("bit");

                    b.Property<long>("LivingArea")
                        .HasColumnType("bigint");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<byte>("Sleeps")
                        .HasColumnType("tinyint");

                    b.Property<long>("TerraceArea")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("HolidayHomes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bathrooms = (byte)2,
                            Bedrooms = (byte)3,
                            Description = "Santa Fe 1291",
                            DistanceToAirport = (byte)12,
                            DistanceToBeach = (byte)60,
                            DistanceToShopping = (byte)2,
                            GardenArea = 70L,
                            HasBalcony = false,
                            HasPatio = true,
                            HasWiFi = true,
                            LivingArea = 20L,
                            OwnerId = 1,
                            Sleeps = (byte)5,
                            TerraceArea = 0L
                        },
                        new
                        {
                            Id = 2,
                            Bathrooms = (byte)3,
                            Bedrooms = (byte)4,
                            Description = "Avenida Siempre Viva 1234",
                            DistanceToAirport = (byte)15,
                            DistanceToBeach = (byte)10,
                            DistanceToShopping = (byte)3,
                            GardenArea = 50L,
                            HasBalcony = true,
                            HasPatio = true,
                            HasWiFi = true,
                            LivingArea = 40L,
                            OwnerId = 1,
                            Sleeps = (byte)4,
                            TerraceArea = 30L
                        },
                        new
                        {
                            Id = 3,
                            Bathrooms = (byte)1,
                            Bedrooms = (byte)5,
                            Description = "Calle Salamanca 13",
                            DistanceToAirport = (byte)50,
                            DistanceToBeach = (byte)70,
                            DistanceToShopping = (byte)8,
                            GardenArea = 0L,
                            HasBalcony = true,
                            HasPatio = false,
                            HasWiFi = true,
                            LivingArea = 10L,
                            OwnerId = 1,
                            Sleeps = (byte)5,
                            TerraceArea = 10L
                        });
                });

            modelBuilder.Entity("Entities.HolidayHomeImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HolidayHomeId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HolidayHomeId");

                    b.ToTable("HolidayHomeImage");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "1",
                            HolidayHomeId = 1,
                            Url = "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/55424/9700320-55424-L%27Estartit-Apartment_Crop_450_337.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Description = "2",
                            HolidayHomeId = 1,
                            Url = "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/55424/9700325-55424-L'Estartit-Apartment_Crop_450_337.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Description = "3",
                            HolidayHomeId = 1,
                            Url = "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/55424/9700326-55424-L'Estartit-Apartment_Crop_450_337.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Description = "4",
                            HolidayHomeId = 2,
                            Url = "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/30984/5704854-30984-Roses-Apartment_Crop_450_337.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Description = "5",
                            HolidayHomeId = 2,
                            Url = "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/30984/5807028-30984-Roses-Apartment_Crop_450_337.jpg"
                        },
                        new
                        {
                            Id = 6,
                            Description = "6",
                            HolidayHomeId = 2,
                            Url = "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/30984/5798711-30984-Roses-Apartment_Crop_450_337.jpg"
                        });
                });

            modelBuilder.Entity("Entities.HolidayHomesOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HolidayHomesOwners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "fabriciosvallasciani@hotmail.com",
                            FirstName = "Fabricio",
                            LastName = "Vallasciani",
                            Telephone = "+549341678888"
                        },
                        new
                        {
                            Id = 2,
                            Email = "susanabmarcos@hotmail.com",
                            FirstName = "Susana",
                            LastName = "Marcos",
                            Telephone = "+54934933079"
                        },
                        new
                        {
                            Id = 3,
                            Email = "peterpetrelli@hotmail.com",
                            FirstName = "Peter",
                            LastName = "Petrelli",
                            Telephone = "+44760608930"
                        });
                });

            modelBuilder.Entity("Entities.HolidayHome", b =>
                {
                    b.HasOne("Entities.HolidayHomesOwner", "Owner")
                        .WithMany("HolidayHomes")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.HolidayHomeImage", b =>
                {
                    b.HasOne("Entities.HolidayHome", null)
                        .WithMany("ImagesList")
                        .HasForeignKey("HolidayHomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
