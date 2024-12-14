using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class Track : Entity
{
	public string Title { get; set; } = string.Empty;
	public string Path { get; set; } = string.Empty;
	
	public Guid MusicGenreId { get; set; }
	public required MusicGenre MusicGenre { get; set; }
}