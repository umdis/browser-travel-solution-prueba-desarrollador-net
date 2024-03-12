using BrowserTravel.MilesCarRental.Core.Entities;
using BrowserTravel.MilesCarRental.Core.Interfaces.Repositories;
using BrowserTravel.MilesCarRental.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BrowserTravel.MilesCarRental.Infrastructure.Repositories;

public class RentRepository: GenericRepository<Rent>, IRentRepository
{
    private readonly AppDbContext _context;

    public RentRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    /// <summary>
    /// Devuelve un listado detallado de registros de renta
    /// </summary>
    /// <param name="idPickupLocatity"></param>
    /// <param name="idReturnLocatity"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<IReadOnlyList<Rent>> GetAll()
    {
        return await _context.Rents.Include(r => r.Vehicle)
                                    .Include(r => r.ReturnLocatity)
                                    .Include(r => r.PickupLocatity).ToListAsync();
    }

    /// <summary>
    /// Devuelve un listado de registros de renta teniendo en cuenta la localidad donde se encuantran en el momento y la localidad donde se van a encontrar en el fururo
    /// </summary>
    /// <param name="idPickupLocatity"></param>
    /// <param name="idReturnLocatity"></param>
    /// <returns></returns>
    public async Task<IReadOnlyList<Rent>> GetVehiclesFreeRent(int idPickupLocatity, int idReturnLocatity)
    {
        return await _context.Rents.Where(r => r.IdPickupLocatity == idPickupLocatity || r.IdReturnLocatity == idPickupLocatity)
                            .Include(r => r.Vehicle).ToListAsync();
    }
}
