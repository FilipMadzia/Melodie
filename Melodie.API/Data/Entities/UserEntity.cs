using Melodie.API.Data.Entities.LikedEntities;
using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class UserEntity : BaseEntity
{
	public required string Email { get; set; }
	public required string Password { get; set; }
	public QueueEntity? Queue { get; set; }
	public ICollection<PlaylistEntity>? Playlists { get; set; }
	public ICollection<LikedTrackEntity>? LikedTracks { get; set; }
	public ICollection<LikedAlbumEntity>? LikedAlbums { get; set; }
	public ICollection<LikedSingleEntity>? LikedSingles { get; set; }
	public ICollection<LikedArtistEntity>? LikedArtists { get; set; }
}
