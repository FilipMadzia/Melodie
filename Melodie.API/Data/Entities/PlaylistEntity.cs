﻿namespace Melodie.API.Data.Entities;

public class PlaylistEntity : BaseEntity
{
	public required string Name { get; set; }
	public string? Description { get; set; }
	public ICollection<TrackEntity>? Tracks { get; set; }
}
