using Melodie.API.Data.Entities;
using Melodie.API.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Repositories;

public class UserRepository(MelodieAPIContext context) : BaseRepository<UserEntity>(context)
{
	readonly MelodieAPIContext _context = context;

	public override async Task<IEnumerable<UserEntity>> GetAllAsync() => await _context.Users
		.Include(x => x.LikedAlbums)
		.Include(x => x.LikedArtists)
		.Include(x => x.LikedSingles)
		.Include(x => x.LikedTracks)
		.Where(x => x.EntityStatus == EntityStatus.Active)
		.ToListAsync();

	public override async Task<UserEntity?> GetById(Guid id) => await _context.Users
		.Include(x => x.LikedAlbums)
		.Include(x => x.LikedArtists)
		.Include(x => x.LikedSingles)
		.Include(x => x.LikedTracks)
		.FirstOrDefaultAsync(x => x.Id == id && x.EntityStatus == EntityStatus.Active);
}
