using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class MusicGenreEntity : BaseEntity
{
	public required string Name { get; set; }
}
