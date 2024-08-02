using Melodie.API.Data.Entities;
using Melodie.API.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Repositories;

public class PlaylistRepository(MelodieAPIContext context) : BaseRepository<PlaylistEntity>(context)
{
    readonly MelodieAPIContext _context = context;

    public override async Task<IEnumerable<PlaylistEntity>> GetAllAsync() => await _context.Playlists
        .Include(x => x.Tracks)
            .ThenInclude(x => x.MusicGenres)
        .Where(x => x.EntityStatus == EntityStatus.Active)
        .ToListAsync();

    public override async Task<PlaylistEntity?> GetById(Guid id) => await _context.Playlists
        .FirstOrDefaultAsync(x => x.Id == id && x.EntityStatus == EntityStatus.Active);
}