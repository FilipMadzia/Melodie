namespace Melodie.API.Data.Entities;

public class Playlist : BaseEntity
{
	public required string Name { get; set; }
	public string? Description { get; set; }
	public ICollection<Track>? Tracks { get; set; }
}
