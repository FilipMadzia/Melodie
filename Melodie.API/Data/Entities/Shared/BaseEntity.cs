using System.ComponentModel.DataAnnotations;
using Melodie.API.Data.Enums;

namespace Melodie.API.Data.Entities.Shared;

public abstract class BaseEntity
{
	[Key]
	public Guid Id { get; private set; } = Guid.NewGuid();

	public DateTime CreatedAt { get; private set; } = DateTime.Now;
	public DateTime UpdatedAt { get; set; }
	/// <summary>
	/// Set only if a specific user creates entity
	/// </summary>
	public Guid? CreatedBy { get; private set; }
	public Guid? UpdatedBy { get; set; }
	public EntityStatus EntityStatus { get; set; } = EntityStatus.Active;
}