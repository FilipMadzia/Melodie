using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class ArtistMusicGenreEntity : BaseEntity
{
	public Guid ArtistId { get; set; }
	public Guid MusicGenreId { get; set; }
}
