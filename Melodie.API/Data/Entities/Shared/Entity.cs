using System.ComponentModel.DataAnnotations;
using Melodie.API.Data.Enums;

namespace Melodie.API.Data.Entities.Shared;

public abstract class Entity
{
	[Key]
	public Guid Id { get; private set; } = Guid.NewGuid();
	public DateTime CreatedAt { get; private set; } = DateTime.Now;
	public DateTime UpdatedAt { get; set; }
	public EntityStatus EntityStatus { get; set; } = EntityStatus.Active;
}