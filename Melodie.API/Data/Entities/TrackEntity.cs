namespace Melodie.API.Data.Entities;

public class TrackEntity : BaseEntity
{
	public required string Title { get; set; }
	public ICollection<MusicGenreEntity>? MusicGenres { get; set; }
}
