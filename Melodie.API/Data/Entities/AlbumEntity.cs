using Melodie.API.Data.Entities.Shared;
using Melodie.API.Data.Entities.TrackEntities;

namespace Melodie.API.Data.Entities;

public class AlbumEntity : BaseEntity
{
	public required string Title { get; set; }
	public DateOnly ReleaseDate { get; set; }
}
