using System.ComponentModel.DataAnnotations;
using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class User : Entity
{
	[MaxLength(50)]
	public string Username { get; set; } = string.Empty;
	[MaxLength(50)]
	public string Email { get; set; } = string.Empty;
	[MaxLength(200)]
	public string HashedPassword { get; set; } = string.Empty;

	public ICollection<Artist> LikedArtists { get; set; } = [];
	
	public ICollection<Album> LikedAlbums { get; set; } = [];
	
	public ICollection<Track> LikedTracks { get; set; } = [];
}