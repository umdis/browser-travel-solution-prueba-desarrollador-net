using BrowserTravel.MilesCarRental.Core.Entities;

namespace BrowserTravel.MilesCarRental.Application.Interfaces;

public interface IRentService
{
    Task<IReadOnlyList<Vehicle>> GetVehiclesForRentAsync(int idPickupLocatity, int idReturnLocatity);

    Task CreateSeedRent();
}