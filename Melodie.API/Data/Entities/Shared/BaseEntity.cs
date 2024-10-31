using System.ComponentModel.DataAnnotations;
using Melodie.API.Data.Enums;

namespace Melodie.API.Data.Entities.Shared;

public abstract class BaseEntity
{
	[Key]
	public Guid Id { get; private set; }
	public DateTime CreatedAt { get; private set; }
	public DateTime UpdatedAt { get; set; }
	/// <summary>
	/// Set only if a specific user creates entity
	/// </summary>
	public Guid? CreatedBy { get; private set; }
	public Guid? UpdatedBy { get; set; }
	public EntityStatus EntityStatus { get; set; }

	protected BaseEntity()
	{
		OnEntityInit();
	}

	protected BaseEntity(Guid userId)
	{
		OnEntityInit(userId);
	}

	void OnEntityInit(Guid? userId = null)
	{
		Id = Guid.NewGuid();
		CreatedAt = DateTime.Now;
		EntityStatus = EntityStatus.Active;
		
		if(userId != null) CreatedBy = userId;
	}
}