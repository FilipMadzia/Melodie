using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class Track : Entity
{
	[MaxLength(50)]
	public string Title { get; set; } = string.Empty;
	[NotMapped]
	public string TrackUrl => $"/Tracks/{Id}";
	
	public Guid MusicGenreId { get; set; }
	public required MusicGenre MusicGenre { get; set; }

	public ICollection<User> LikedByUsers { get; set; } = [];
}