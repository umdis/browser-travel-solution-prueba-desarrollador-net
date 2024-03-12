namespace BrowserTravel.MilesCarRental.WebAPI.Mappers;

public static class VehicleMapper
{
    public static VehicleDto Maps(this Vehicle entity)
    {
        return new VehicleDto(entity.LicensePlate, entity.Model, entity.Reference, entity.State);
    }

    public static ICollection<VehicleDto> Maps(this IReadOnlyList<Vehicle> vehicles)
    {
        var list = new List<VehicleDto>();
        foreach (var item in vehicles)
        {
            list.Add(item.Maps());
        }
        return list;
    }
}
