using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class QueueEntity : BaseEntity
{
	public Guid UserId { get; set; }
}
