using Melodie.API.Data.Entities.LikedEntities;
using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class UserEntity : BaseEntity
{
	public required string Email { get; set; }
	public required string Password { get; set; }
}
