namespace BrowserTravel.MilesCarRental.WebAPI.Dtos;

public record RentDto(LocalityDto PickupLocatity, DateTime PickupDate, LocalityDto ReturnLocatity, DateTime ReturnDate, VehicleDto Vehicle, bool State);
public record VehicleDto(string LicensePlat, string Model, string Reference, bool State);
public record LocalityDto(string Name, bool State);
public record QueryRentDto(int IdPickupLocatity, int IdReturnLocatity);
public record VehicleRentDto(string LicensePlat, string Model, string Reference);