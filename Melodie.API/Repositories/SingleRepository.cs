using Melodie.API.Data.Entities;
using Melodie.API.Data.Enums;
using Melodie.API.Repositories.Shared;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Repositories;

public class SingleRepository(MelodieAPIContext context) : BaseRepository<SingleEntity>(context)
{
    readonly MelodieAPIContext _context = context;

    public override async Task<IEnumerable<SingleEntity>> GetAllAsync() => await _context.Singles
        .Include(x => x.Track)
            .ThenInclude(x => x.Track.MusicGenres)
        .Where(x => x.EntityStatus == EntityStatus.Active)
        .ToListAsync();

    public override async Task<SingleEntity?> GetByIdAsync(Guid id) => await _context.Singles
        .Include(x => x.Track)
            .ThenInclude(x => x.Track.MusicGenres)
        .FirstOrDefaultAsync(x => x.Id == id && x.EntityStatus == EntityStatus.Active);
}