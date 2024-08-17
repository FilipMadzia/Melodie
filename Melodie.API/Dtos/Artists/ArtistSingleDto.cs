namespace Melodie.API.Dtos.Artists;

public class ArtistSingleDto
{
	public string Title { get; set; } = string.Empty;
	public string CoverUrl { get; set; } = string.Empty;
	public ArtistSingleTrackDto Track { get; set; } = new();
	public DateOnly ReleaseDate { get; set; }
}
