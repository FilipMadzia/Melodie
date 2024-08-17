namespace Melodie.API.Dtos.Artists;

public class ArtistAlbumDto
{
	public string Title { get; set; } = string.Empty;
	public string CoverUrl { get; set; } = string.Empty;	
	public DateOnly ReleaseDate { get; set; }
	public List<ArtistAlbumTrackDto> Tracks { get; set; } = [];
}
