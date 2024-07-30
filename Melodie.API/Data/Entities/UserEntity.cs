namespace Melodie.API.Data.Entities;

public class UserEntity : BaseEntity
{
	public required string Email { get; set; }
	public required string Password { get; set; }
	public QueueEntity Queue { get; set; } = null!;
	public ICollection<PlaylistEntity>? Playlists { get; set; }
	public ICollection<TrackEntity>? LikedTracks { get; set; }
	public ICollection<AlbumEntity>? LikedAlbums { get; set; }
	public ICollection<SingleEntity>? LikedSingles { get; set; }
	public ICollection<ArtistEntity>? LikedArtists { get; set; }
}
