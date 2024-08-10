using Melodie.API.Data.Entities.Shared;
using Melodie.API.Data.Entities.TrackEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melodie.API.Data.Entities;

public class SingleEntity : BaseEntity
{
	[ForeignKey(nameof(SingleTrackEntity))]
	public required SingleTrackEntity Track { get; set; }
}
