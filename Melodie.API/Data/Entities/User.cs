namespace Melodie.API.Data.Entities;

public class User : BaseEntity
{
	public required string Email { get; set; }
	public required string Password { get; set; }
	public Queue? Queue { get; set; }
	public ICollection<Playlist>? Playlists { get; set; }
	public ICollection<Track>? LikedTracks { get; set; }
	public ICollection<Album>? LikedAlbums { get; set; }
	public ICollection<Single>? LikedSingles { get; set; }
	public ICollection<Artist>? LikedArtists { get; set; }
}
