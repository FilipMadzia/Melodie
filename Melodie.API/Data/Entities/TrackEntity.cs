﻿using Melodie.API.Data.Entities.Shared;

namespace Melodie.API.Data.Entities;

public class TrackEntity : BaseEntity
{
	public required string Title { get; set; }
}
