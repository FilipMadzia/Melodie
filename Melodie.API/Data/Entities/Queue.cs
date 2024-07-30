namespace Melodie.API.Data.Entities;

public class Queue : BaseEntity
{
	public ICollection<Track>? Tracks { get; set; }
	public Guid UserId { get; set; }
	public User User { get; set; } = null!;
}
