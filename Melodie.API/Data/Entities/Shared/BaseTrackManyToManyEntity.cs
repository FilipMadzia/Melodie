namespace Melodie.API.Data.Entities.Shared;

public abstract class BaseTrackManyToManyEntity : BaseEntity
{
	public Guid TrackId { get; set; }
	public Guid EntityId { get; set; }
}
