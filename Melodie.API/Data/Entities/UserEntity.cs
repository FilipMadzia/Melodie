using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class UserEntity : BaseEntity
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}