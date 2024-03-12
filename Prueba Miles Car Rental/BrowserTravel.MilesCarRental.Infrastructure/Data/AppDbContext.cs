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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Locality>().HasData(new Locality { Id = 1, Name = "Fontibon", State = true });
    }
}