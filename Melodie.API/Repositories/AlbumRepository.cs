﻿using Melodie.API.Data.Entities;
using Melodie.API.Data.Enums;
using Melodie.API.Repositories.Shared;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Repositories;

public class AlbumRepository(MelodieAPIContext context) : BaseRepository<AlbumEntity>(context)
{
	readonly MelodieAPIContext _context = context;

	public override async Task<IEnumerable<AlbumEntity>> GetAllAsync() => await _context.Albums
		.Include(x => x.Tracks)
		.Where(x => x.EntityStatus == EntityStatus.Active)
		.ToListAsync();

	public override async Task<AlbumEntity?> GetByIdAsync(Guid id) => await _context.Albums
		.FirstOrDefaultAsync(x => x.Id == id && x.EntityStatus == EntityStatus.Active);
}
