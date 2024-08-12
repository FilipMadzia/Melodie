namespace Melodie.API.Data.Entities.Shared;

public abstract class BaseLikedEntity : BaseEntity
{
    public Guid UserId { get; set; }
    public Guid EntityId { get; set; }
}
