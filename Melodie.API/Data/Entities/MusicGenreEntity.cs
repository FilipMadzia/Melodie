using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class MusicGenreEntity : BaseEntity
{
	public string Name { get; set; } = string.Empty;
}