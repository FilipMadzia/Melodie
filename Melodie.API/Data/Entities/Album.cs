namespace Melodie.API.Data.Entities;

public class Album : BaseEntity
{
	public required string Title { get; set; }
	public DateOnly ReleaseDate { get; set; }
	public required ICollection<Track> Tracks { get; set; }
}
