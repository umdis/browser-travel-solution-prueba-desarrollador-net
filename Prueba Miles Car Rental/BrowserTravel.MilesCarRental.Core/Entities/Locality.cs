namespace BrowserTravel.MilesCarRental.Core.Entities;

[Table("Locations")]
public class Locality : BaseEntity
{
    [Required]
    [StringLength(50)]
    public string? Name { get; set; }

    [Required]
    public bool State { get; set; } = true;
}