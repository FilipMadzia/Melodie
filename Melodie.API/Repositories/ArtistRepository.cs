using Melodie.API.Data.Entities;
using Melodie.API.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Repositories;

public class ArtistRepository(MelodieAPIContext context) : BaseRepository<ArtistEntity>(context)
{
    readonly MelodieAPIContext _context = context;

    public override async Task<IEnumerable<ArtistEntity>> GetAllAsync() => await _context.Artists
        .Include(x => x.Albums)
        .Include(x => x.Singles)
        .Include(x => x.Tracks)
        .Where(x => x.EntityStatus == EntityStatus.Active)
        .ToListAsync();

    public override async Task<ArtistEntity?> GetById(Guid id) => await _context.Artists
        .Include(x => x.Albums)
        .Include(x => x.Singles)
        .Include(x => x.Tracks)
        .FirstOrDefaultAsync(x => x.Id == id && x.EntityStatus == EntityStatus.Active);
}
