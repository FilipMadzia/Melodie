using Melodie.API.Data.Entities;
using Melodie.API.Repositories.Shared;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Repositories;

public class SingleRepository(MelodieAPIContext context) : BaseRepository<SingleEntity>(context)
{
	readonly MelodieAPIContext _context = context;

	public async Task<List<SingleEntity>> GetByArtistIdAsync(Guid artistId) => await _context.Singles
		.Where(x => x.ArtistId == artistId)
		.ToListAsync();
}