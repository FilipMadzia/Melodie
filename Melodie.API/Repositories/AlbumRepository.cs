using Melodie.API.Data.Entities;
using Melodie.API.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Repositories;

public class AlbumRepository(MelodieAPIContext _context) : BaseRepository<Album>(_context)
{
	public override async Task<IEnumerable<Album>> GetAllAsync() => await _context.Albums
		.Include(x => x.Tracks)
		.Where(x => x.EntityStatus == EntityStatus.Active)
		.ToListAsync();

	public override async Task<Album?> GetById(Guid id) => await _context.Albums
		.FirstOrDefaultAsync(x => x.Id == id && x.EntityStatus == EntityStatus.Active);
}
