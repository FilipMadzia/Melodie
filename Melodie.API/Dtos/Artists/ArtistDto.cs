namespace Melodie.API.Dtos.Artists;

public class ArtistDto
{
	public string Name { get; set; } = string.Empty;
	public string CoverUrl { get; set; } = string.Empty;
	public List<ArtistSingleDto> Singles { get; set; } = [];
	public List<ArtistAlbumDto> Albums { get; set; } = [];
}
