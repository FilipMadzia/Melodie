using Melodie.API.Data.Entities.Shared;
using Melodie.API.Data.Entities.TrackEntities;

namespace Melodie.API.Data.Entities;

public class QueueEntity : BaseEntity
{
	public Guid UserId { get; set; }
}
