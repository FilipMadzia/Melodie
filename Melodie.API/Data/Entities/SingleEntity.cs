using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class SingleEntity : BaseEntity
{
	public Guid TrackId { get; set; }
	public DateOnly ReleaseDate { get; set; }
}
