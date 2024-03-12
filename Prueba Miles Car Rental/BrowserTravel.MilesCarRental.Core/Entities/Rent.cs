namespace BrowserTravel.MilesCarRental.Core.Entities;

[Table("Rents")]
public class Rent : BaseEntity
{
    public int IdPickupLocatity { get; set; }

    [ForeignKey("IdPickupLocatity")]
    public Locality? PickupLocatity { get; set; }

    public int IdReturnLocatity { get; set; }

    [ForeignKey("IdReturnLocatity")]
    public Locality? ReturnLocatity { get; set; }

    public int IdVehicle { get; set; }

    [ForeignKey("IdVehicle")]
    public Vehicle? Vehicle { get; set; }
}
