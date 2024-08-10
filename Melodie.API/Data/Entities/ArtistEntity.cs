using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class ArtistEntity : BaseEntity
{
	public required string Name { get; set; }
	public ICollection<AlbumEntity>? Albums { get; set; }
	public ICollection<SingleEntity>? Singles { get; set; }
	public ICollection<TrackEntity>? Tracks { get; set; }
}
