using BrowserTravel.MilesCarRental.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BrowserTravel.MilesCarRental.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Locality> Locations { get; set; }
    public DbSet<Rent> Rents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Localidades
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 1, Name = "FONTIBON", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 2, Name = "CIUDAD BOLIVAR", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 3, Name = "SUBA", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 4, Name = "RAFAEL URIBE URIBE", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 5, Name = "KENNEDY", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 6, Name = "USME", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 7, Name = "LOS MARTIRES", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 8, Name = "BARRIOS UNIDOS", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 9, Name = "ENGATIVA", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 10, Name = "CANDELARIA", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 11, Name = "CHAPINERO", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 12, Name = "ANTONIO NARIÑO", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 13, Name = "TEUSAQUILLO", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 14, Name = "SUMAPAZ", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 15, Name = "SAN CRISTOBAL", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 16, Name = "USAQUEN", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 17, Name = "TUNJUELITO", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 18, Name = "BOSA", State = true });
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 19, Name = "PUENTE ARANDA", State = true });

        //Vehiculos
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 1, LicensePlate = "ABC123", State = true, Reference = "Toyota Camry", Model = "2020" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 2, LicensePlate = "XYZ789", State = true, Reference = "Honda Civic", Model = "2019" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 3, LicensePlate = "DEF456", State = true, Reference = "Ford F-150", Model = "2021" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 4, LicensePlate = "GHI789", State = true, Reference = "Chevrolet Silverado", Model = "2018" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 5, LicensePlate = "JKL321", State = true, Reference = "Tesla Model S", Model = "2022" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 6, LicensePlate = "MNO654", State = true, Reference = "Jeep Wrangler", Model = "2017" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 7, LicensePlate = "PQR987", State = true, Reference = "Subaru Outback", Model = "2020" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 8, LicensePlate = "STU654", State = true, Reference = "Nissan Altima", Model = "2019" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 9, LicensePlate = "VWX321", State = true, Reference = "BMW 3 Series", Model = "2021" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 10, LicensePlate = "YZA987", State = true, Reference = "Audi A4", Model = "2018" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 11, LicensePlate = "BCD654", State = true, Reference = "Mercedes-Benz C-Class", Model = "2017" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 12, LicensePlate = "EFG321", State = true, Reference = "Toyota Corolla", Model = "2020" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 13, LicensePlate = "HIJ987", State = true, Reference = "Honda Accord", Model = "2019" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 14, LicensePlate = "KLM654", State = true, Reference = "Ford Mustang", Model = "2021" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 15, LicensePlate = "NOP321", State = true, Reference = "Chevrolet Camaro", Model = "2018" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 16, LicensePlate = "QRS987", State = true, Reference = "Tesla Model 3", Model = "2022" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 17, LicensePlate = "TUV654", State = true, Reference = "Jeep Grand Cherokee", Model = "2017" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 18, LicensePlate = "VWX321", State = true, Reference = "Subaru Forester", Model = "2020" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 19, LicensePlate = "YZA987", State = true, Reference = "Nissan Rogue", Model = "2019" });
        modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 20, LicensePlate = "BCD654", State = true, Reference = "Toyota Highlander", Model = "2021" });
    }
}