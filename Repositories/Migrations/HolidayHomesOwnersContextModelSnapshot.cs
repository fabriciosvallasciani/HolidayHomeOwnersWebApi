﻿// <auto-generated />
using Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Repositories.Migrations
{
    [DbContext(typeof(HolidayHomesOwnersContext))]
    partial class HolidayHomesOwnersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HolidayHomesOwnersWebApi.Entities.HolidayHome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("HolidayHomes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Santa Fe 1291",
                            OwnerId = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = "Salamanca 13",
                            OwnerId = 1
                        });
                });

            modelBuilder.Entity("HolidayHomesOwnersWebApi.Entities.HolidayHomesOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HolidayHomesOwners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Fabricio",
                            LastName = "Vallasciani"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Susana",
                            LastName = "Marcos"
                        });
                });

            modelBuilder.Entity("HolidayHomesOwnersWebApi.Entities.HolidayHome", b =>
                {
                    b.HasOne("HolidayHomesOwnersWebApi.Entities.HolidayHomesOwner", "Owner")
                        .WithMany("HolidayHomes")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
