using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class Artist : Entity
{
	public string Name { get; set; } = string.Empty;
	public string ImageUrl { get; set; } = string.Empty;

	public ICollection<Album> Albums { get; set; } = [];
}