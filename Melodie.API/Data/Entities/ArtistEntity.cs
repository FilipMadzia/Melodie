using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class ArtistEntity : BaseEntity
{
	public required string Name { get; set; }
}
