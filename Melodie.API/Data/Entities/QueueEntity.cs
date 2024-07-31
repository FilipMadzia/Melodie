namespace Melodie.API.Data.Entities;

public class QueueEntity : BaseEntity
{
	public ICollection<TrackEntity>? Tracks { get; set; }
	public Guid UserId { get; set; }
	public UserEntity User { get; set; } = null!;
}
