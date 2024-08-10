namespace Melodie.API.Data.Entities.Shared;

public abstract class BaseLikedEntity<T> : BaseEntity where T : BaseEntity
{
    public required UserEntity User { get; set; }
    public required T Liked { get; set; }
}
