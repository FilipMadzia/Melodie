using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class Album : Entity
{
	[MaxLength(50)]
	public string Title { get; set; } = string.Empty;
	[NotMapped]
	public string CoverUrl => $"/Covers/{Id}";
	public DateTime ReleaseDate { get; set; }

	public Guid ArtistId { get; set; }
	public required Artist Artist { get; set; }
	
	public ICollection<Track> Tracks { get; set; } = [];

	public ICollection<User> LikedByUsers { get; set; } = [];
}