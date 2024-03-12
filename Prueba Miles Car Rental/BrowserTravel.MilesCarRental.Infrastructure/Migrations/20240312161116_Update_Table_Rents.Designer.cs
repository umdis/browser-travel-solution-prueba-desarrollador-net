﻿// <auto-generated />
using System;
using BrowserTravel.MilesCarRental.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BrowserTravel.MilesCarRental.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240312161116_Update_Table_Rents")]
    partial class Update_Table_Rents
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("BrowserTravel.MilesCarRental.Core.Entities.Locality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool>("State")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "FONTIBON",
                            State = true
                        },
                        new
                        {
                            Id = 2,
                            Name = "CIUDAD BOLIVAR",
                            State = true
                        },
                        new
                        {
                            Id = 3,
                            Name = "SUBA",
                            State = true
                        },
                        new
                        {
                            Id = 4,
                            Name = "RAFAEL URIBE URIBE",
                            State = true
                        },
                        new
                        {
                            Id = 5,
                            Name = "KENNEDY",
                            State = true
                        },
                        new
                        {
                            Id = 6,
                            Name = "USME",
                            State = true
                        },
                        new
                        {
                            Id = 7,
                            Name = "LOS MARTIRES",
                            State = true
                        },
                        new
                        {
                            Id = 8,
                            Name = "BARRIOS UNIDOS",
                            State = true
                        },
                        new
                        {
                            Id = 9,
                            Name = "ENGATIVA",
                            State = true
                        },
                        new
                        {
                            Id = 10,
                            Name = "CANDELARIA",
                            State = true
                        },
                        new
                        {
                            Id = 11,
                            Name = "CHAPINERO",
                            State = true
                        },
                        new
                        {
                            Id = 12,
                            Name = "ANTONIO NARIÑO",
                            State = true
                        },
                        new
                        {
                            Id = 13,
                            Name = "TEUSAQUILLO",
                            State = true
                        },
                        new
                        {
                            Id = 14,
                            Name = "SUMAPAZ",
                            State = true
                        },
                        new
                        {
                            Id = 15,
                            Name = "SAN CRISTOBAL",
                            State = true
                        },
                        new
                        {
                            Id = 16,
                            Name = "USAQUEN",
                            State = true
                        },
                        new
                        {
                            Id = 17,
                            Name = "TUNJUELITO",
                            State = true
                        },
                        new
                        {
                            Id = 18,
                            Name = "BOSA",
                            State = true
                        },
                        new
                        {
                            Id = 19,
                            Name = "PUENTE ARANDA",
                            State = true
                        });
                });

            modelBuilder.Entity("BrowserTravel.MilesCarRental.Core.Entities.Rent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdPickupLocatity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdReturnLocatity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdVehicle")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PickupDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("State")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdPickupLocatity");

                    b.HasIndex("IdReturnLocatity");

                    b.HasIndex("IdVehicle");

                    b.ToTable("Rents");
                });

            modelBuilder.Entity("BrowserTravel.MilesCarRental.Core.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.Property<string>("Reference")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<bool>("State")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LicensePlate = "ABC123",
                            Model = "2020",
                            Reference = "Toyota Camry",
                            State = true
                        },
                        new
                        {
                            Id = 2,
                            LicensePlate = "XYZ789",
                            Model = "2019",
                            Reference = "Honda Civic",
                            State = true
                        },
                        new
                        {
                            Id = 3,
                            LicensePlate = "DEF456",
                            Model = "2021",
                            Reference = "Ford F-150",
                            State = true
                        },
                        new
                        {
                            Id = 4,
                            LicensePlate = "GHI789",
                            Model = "2018",
                            Reference = "Chevrolet Silverado",
                            State = true
                        },
                        new
                        {
                            Id = 5,
                            LicensePlate = "JKL321",
                            Model = "2022",
                            Reference = "Tesla Model S",
                            State = true
                        },
                        new
                        {
                            Id = 6,
                            LicensePlate = "MNO654",
                            Model = "2017",
                            Reference = "Jeep Wrangler",
                            State = true
                        },
                        new
                        {
                            Id = 7,
                            LicensePlate = "PQR987",
                            Model = "2020",
                            Reference = "Subaru Outback",
                            State = true
                        },
                        new
                        {
                            Id = 8,
                            LicensePlate = "STU654",
                            Model = "2019",
                            Reference = "Nissan Altima",
                            State = true
                        },
                        new
                        {
                            Id = 9,
                            LicensePlate = "VWX321",
                            Model = "2021",
                            Reference = "BMW 3 Series",
                            State = true
                        },
                        new
                        {
                            Id = 10,
                            LicensePlate = "YZA987",
                            Model = "2018",
                            Reference = "Audi A4",
                            State = true
                        },
                        new
                        {
                            Id = 11,
                            LicensePlate = "BCD654",
                            Model = "2017",
                            Reference = "Mercedes-Benz C-Class",
                            State = true
                        },
                        new
                        {
                            Id = 12,
                            LicensePlate = "EFG321",
                            Model = "2020",
                            Reference = "Toyota Corolla",
                            State = true
                        },
                        new
                        {
                            Id = 13,
                            LicensePlate = "HIJ987",
                            Model = "2019",
                            Reference = "Honda Accord",
                            State = true
                        },
                        new
                        {
                            Id = 14,
                            LicensePlate = "KLM654",
                            Model = "2021",
                            Reference = "Ford Mustang",
                            State = true
                        },
                        new
                        {
                            Id = 15,
                            LicensePlate = "NOP321",
                            Model = "2018",
                            Reference = "Chevrolet Camaro",
                            State = true
                        },
                        new
                        {
                            Id = 16,
                            LicensePlate = "QRS987",
                            Model = "2022",
                            Reference = "Tesla Model 3",
                            State = true
                        },
                        new
                        {
                            Id = 17,
                            LicensePlate = "TUV654",
                            Model = "2017",
                            Reference = "Jeep Grand Cherokee",
                            State = true
                        },
                        new
                        {
                            Id = 18,
                            LicensePlate = "VWX321",
                            Model = "2020",
                            Reference = "Subaru Forester",
                            State = true
                        },
                        new
                        {
                            Id = 19,
                            LicensePlate = "YZA987",
                            Model = "2019",
                            Reference = "Nissan Rogue",
                            State = true
                        },
                        new
                        {
                            Id = 20,
                            LicensePlate = "BCD654",
                            Model = "2021",
                            Reference = "Toyota Highlander",
                            State = true
                        });
                });

            modelBuilder.Entity("BrowserTravel.MilesCarRental.Core.Entities.Rent", b =>
                {
                    b.HasOne("BrowserTravel.MilesCarRental.Core.Entities.Locality", "PickupLocatity")
                        .WithMany()
                        .HasForeignKey("IdPickupLocatity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BrowserTravel.MilesCarRental.Core.Entities.Locality", "ReturnLocatity")
                        .WithMany()
                        .HasForeignKey("IdReturnLocatity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BrowserTravel.MilesCarRental.Core.Entities.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("IdVehicle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PickupLocatity");

                    b.Navigation("ReturnLocatity");

                    b.Navigation("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}
