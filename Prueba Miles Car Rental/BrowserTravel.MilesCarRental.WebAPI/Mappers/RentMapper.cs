namespace BrowserTravel.MilesCarRental.WebAPI.Mappers;

public static class RentMapper
{
    public static VehicleRentDto Map(this Vehicle entity)
    {
        return new VehicleRentDto(entity.LicensePlate, entity.Model, entity.Reference);
    }

    public static ICollection<VehicleRentDto> Map(this IReadOnlyList<Vehicle> vehicles)
    {
        var list = new List<VehicleRentDto>();
        foreach (var item in vehicles)
        {
            list.Add(item.Map());
        }
        return list;
    }

    public static RentDto Map(this Rent entity)
    {
        return new RentDto(entity.PickupLocatity.Map(), entity.PickupDate, entity.ReturnLocatity.Map(), entity.ReturnDate, entity.Vehicle.Maps(), entity.State);
    }

    public static ICollection<RentDto> Map(this IReadOnlyList<Rent> rents)
    {
        var list = new List<RentDto>();
        foreach (var item in rents)
        {
            list.Add(item.Map());
        }
        return list;
    }
}
