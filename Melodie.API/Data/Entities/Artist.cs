using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class Artist : Entity
{
	[MaxLength(50)]
	public string Name { get; set; } = string.Empty;
	[NotMapped]
	public string CoverUrl => $"/ArtistCovers/{Id}";

	public ICollection<Album> Albums { get; set; } = [];

	public ICollection<User> LikedByUsers { get; set; } = [];
}