using BrowserTravel.MilesCarRental.Core.Entities;
using BrowserTravel.MilesCarRental.Core.Interfaces.Repositories;
using BrowserTravel.MilesCarRental.Infrastructure.Data;

namespace BrowserTravel.MilesCarRental.Infrastructure.Repositories;

public class LocalityRepository : GenericRepository<Locality>, ILocalityRepository
{
    private readonly AppDbContext _context;

    public LocalityRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
}
