namespace Melodie.API.Data.Entities.Shared;

public abstract class BaseTrackManyToManyEntity<T> : BaseEntity where T : BaseEntity
{
	public required TrackEntity Track { get; set; }
	public required T ForeignEntity { get; set; }
}
