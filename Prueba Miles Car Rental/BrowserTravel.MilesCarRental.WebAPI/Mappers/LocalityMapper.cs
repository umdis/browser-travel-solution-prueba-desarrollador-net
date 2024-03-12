namespace BrowserTravel.MilesCarRental.WebAPI.Mappers;

public static class LocalityMapper
{
    public static LocalityDto Map(this Locality entity)
    {
        return new LocalityDto(entity.Name, entity.State);
    }

    public static ICollection<LocalityDto> Maps(this IReadOnlyList<Locality> locations)
    {
        var list = new List<LocalityDto>();
        foreach (var item in locations)
        {
            list.Add(item.Map());
        }
        return list;
    }
}
