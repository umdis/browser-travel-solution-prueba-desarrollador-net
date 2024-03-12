using BrowserTravel.MilesCarRental.Application.Interfaces;
using BrowserTravel.MilesCarRental.Core.Entities;
using BrowserTravel.MilesCarRental.Core.Interfaces;
using BrowserTravel.MilesCarRental.Core.Interfaces.Repositories;

namespace BrowserTravel.MilesCarRental.Application.Services;

public class RentService : IRentService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRentRepository _rentRepository;

    public RentService(IUnitOfWork unitOfWork, IRentRepository rentRepository)
    {
        _unitOfWork = unitOfWork;
        _rentRepository = rentRepository;
    }

    /// <summary>
    /// Permite la creación de registros de pruebas en caso de que estos no se encuentren creados en la base de datos
    /// </summary>
    /// <returns></returns>
    public async Task CreateSeedRent()
    {
        var isLoadedData = await _unitOfWork.repository<Rent>().GetAllAsync();

        if (!isLoadedData.Any())
        {
            List<int> vehicleIds = new List<int>();
            for (int i = 1; i <= 20; i++)
            {
                vehicleIds.Add(i);
            }

            // Lista de identificadores de localidades
            List<int> localityIds = new List<int>();
            for (int i = 1; i <= 19; i++)
            {
                localityIds.Add(i);
            }

            Random rnd = new Random();
            List<Rent> rents = new List<Rent>();

            // Generar 20 rentas con datos aleatorios
            for (int i = 0; i < 20; i++)
            {
                Rent rent = new Rent
                {
                    IdPickupLocatity = localityIds[rnd.Next(localityIds.Count)],
                    PickupDate = DateTime.Today.AddDays(rnd.Next(1, 30)),
                    IdReturnLocatity = localityIds[rnd.Next(localityIds.Count)],
                    ReturnDate = DateTime.Today.AddDays(rnd.Next(31, 60)),
                    IdVehicle = vehicleIds[i],
                    State = true
                };

                rents.Add(rent);
            }

            // Cargar los datos de renta en la base de datos
            foreach (var rent in rents)
            {
                _unitOfWork.repository<Rent>().Add(rent);
            }

            await _unitOfWork.Complete();
        }
    }

    /// <summary>
    /// Devuelve un listado de los vehiculos disponibles para rentar la localidad de recogida seleccionada por el usuario
    /// </summary>
    /// <param name="idPickupLocatity"></param>
    /// <param name="idReturnLocatity"></param>
    /// <returns></returns>
    public async Task<IReadOnlyList<Vehicle>> GetVehiclesForRentAsync(int idPickupLocatity, int idReturnLocatity)
    {
        var data = await _rentRepository.GetVehiclesFreeRent(idPickupLocatity, idReturnLocatity);
        return data.Select(r => r.Vehicle).ToList();
    }
}
