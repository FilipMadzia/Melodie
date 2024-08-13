using Melodie.API.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Melodie.API.Data.Entities.Shared;

public abstract class BaseEntity
{
    [Key]
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; set; }
    /// <summary>
    /// Set only if a specific user creates entity
    /// </summary>
    public Guid CreatedBy { get; set; }
    public Guid UpdatedBy { get; set; }
    public EntityStatus EntityStatus { get; set; }

    public BaseEntity()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.Now;
        EntityStatus = EntityStatus.Active;
    }
}
