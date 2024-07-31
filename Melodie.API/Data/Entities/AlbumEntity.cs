namespace Melodie.API.Data.Entities;

public class AlbumEntity : BaseEntity
{
	public required string Title { get; set; }
	public DateOnly ReleaseDate { get; set; }
	public required ICollection<TrackEntity> Tracks { get; set; }
}
