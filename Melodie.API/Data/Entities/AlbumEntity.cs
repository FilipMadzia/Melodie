using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class AlbumEntity : BaseEntity
{
	public Guid ArtistId { get; set; }
	public required string Title { get; set; }
	public DateOnly ReleaseDate { get; set; }
}
