using BrowserTravel.MilesCarRental.Core.Entities;

namespace BrowserTravel.MilesCarRental.Core.Interfaces.Repositories;

public interface IRentRepository: IGenericRepository<Rent>
{
    Task<IReadOnlyList<Rent>> GetVehiclesFreeRent(int idPickupLocatity, int idReturnLocatity);
    Task<IReadOnlyList<Rent>> GetAll();
}
