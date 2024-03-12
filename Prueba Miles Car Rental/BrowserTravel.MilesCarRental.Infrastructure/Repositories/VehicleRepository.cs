using BrowserTravel.MilesCarRental.Core.Entities;
using BrowserTravel.MilesCarRental.Core.Interfaces.Repositories;
using BrowserTravel.MilesCarRental.Infrastructure.Data;

namespace BrowserTravel.MilesCarRental.Infrastructure.Repositories;

public class VehicleRepository : GenericRepository<Vehicle>, IVehicleRepository
{
    private readonly AppDbContext _context;

    public VehicleRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
}
