namespace BrowserTravel.MilesCarRental.Core.Entities;

[Table("Vehicles")]
public class Vehicle : BaseEntity
{
    [Required]
    [StringLength(6)]
    public string? LicensePlate { get; set; }

    [Required]
    [StringLength(4)]
    public string? Model { get; set; }

    [Required]
    [StringLength(30)]
    public string? Reference { get; set; }

    [Required]
    public bool State { get; set; } = true;
}
