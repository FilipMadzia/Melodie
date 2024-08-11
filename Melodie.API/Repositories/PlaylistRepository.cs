using Melodie.API.Data.Entities;
using Melodie.API.Data.Enums;
using Melodie.API.Repositories.Shared;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Repositories;

public class PlaylistRepository(MelodieAPIContext context) : BaseRepository<PlaylistEntity>(context)
{
    readonly MelodieAPIContext _context = context;

    public override async Task<IEnumerable<PlaylistEntity>> GetAllAsync() => await _context.Playlists
        .Include(x => x.Tracks)
        .Where(x => x.EntityStatus == EntityStatus.Active)
        .ToListAsync();

    public override async Task<PlaylistEntity?> GetByIdAsync(Guid id) => await _context.Playlists
        .Include(x => x.Tracks)
        .FirstOrDefaultAsync(x => x.Id == id && x.EntityStatus == EntityStatus.Active);
}