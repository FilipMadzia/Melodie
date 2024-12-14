using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class Album : Entity
{
	public string Title { get; set; } = string.Empty;
	public string CoverUrl { get; set; } = string.Empty;
	public DateTime ReleaseDate { get; set; }

	public required Artist Artist { get; set; }
	
	public ICollection<Track> Tracks { get; set; } = [];
}