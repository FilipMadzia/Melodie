namespace Melodie.API.Data.Entities;

public class Artist : BaseEntity
{
	public required string Name { get; set; }
	public ICollection<Album>? Albums { get; set; }
	public ICollection<Single>? Singles { get; set; }
	public ICollection<Track>? Tracks { get; set; }
}
