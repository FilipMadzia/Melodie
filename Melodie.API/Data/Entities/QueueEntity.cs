using Melodie.API.Data.Entities.Shared;
using Melodie.API.Data.Entities.TrackEntities;

namespace Melodie.API.Data.Entities;

public class QueueEntity : BaseEntity
{
	public ICollection<QueueTrackEntity>? Tracks { get; set; }
	public Guid UserId { get; set; }
	public UserEntity User { get; set; } = null!;
}
