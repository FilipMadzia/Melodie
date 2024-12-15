using System.ComponentModel.DataAnnotations;
using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class MusicGenre : Entity
{
	[MaxLength(50)]
	public string Name { get; set; } = string.Empty;
}