using Melodie.API.Data.Entities;
using Melodie.API.Data.Enums;
using Melodie.API.Repositories.Shared;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Repositories;

public class TrackRepository(MelodieAPIContext context) : BaseRepository<TrackEntity>(context)
{
    readonly MelodieAPIContext _context = context;

    public override async Task<IEnumerable<TrackEntity>> GetAllAsync() => await _context.Tracks
        .Include(x => x.MusicGenres)
        .Where(x => x.EntityStatus == EntityStatus.Active)
        .ToListAsync();

    public override async Task<TrackEntity?> GetByIdAsync(Guid id) => await _context.Tracks
        .Include(x => x.MusicGenres)
        .FirstOrDefaultAsync(x => x.Id == id && x.EntityStatus == EntityStatus.Active);
}