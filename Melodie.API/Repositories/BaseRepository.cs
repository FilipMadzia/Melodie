﻿using Melodie.API.Data.Entities.Shared;
using Melodie.API.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Repositories;

public abstract class BaseRepository<T>(MelodieAPIContext _context) : IBaseRepository<T> where T : BaseEntity
{
	public virtual async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>()
		.Where(x => x.EntityStatus == EntityStatus.Active)
		.ToListAsync();

	public virtual async Task<T?> GetById(Guid id) => await _context.Set<T>()
		.FirstOrDefaultAsync(x => x.Id == id && x.EntityStatus == EntityStatus.Active);
}
