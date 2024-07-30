namespace Melodie.API.Data.Entities;

public class QueueEntity
{
	public ICollection<TrackEntity>? Tracks { get; set; }
	public UserEntity User { get; set; } = null!;
}
