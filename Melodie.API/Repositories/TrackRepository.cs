using Melodie.API.Data.Entities;
using Melodie.API.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Repositories;

public class TrackRepository(MelodieAPIContext context) : BaseRepository<TrackEntity>(context)
{
    readonly MelodieAPIContext _context = context;

    public override async Task<IEnumerable<TrackEntity>> GetAllAsync() => await _context.Tracks
        .Include(x => x.MusicGenres)
        .Where(x => x.EntityStatus == EntityStatus.Active)
        .ToListAsync();

    public override async Task<TrackEntity?> GetById(Guid id) => await _context.Tracks
    .FirstOrDefaultAsync(x => x.Id == id && x.EntityStatus == EntityStatus.Active);
}