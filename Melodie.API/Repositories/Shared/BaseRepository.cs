using Melodie.API.Data.Entities.Shared;
using Melodie.API.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Repositories.Shared;

public abstract class BaseRepository<T>(MelodieAPIContext _context) : IBaseRepository<T> where T : BaseEntity
{
    public virtual async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>()
        .Where(x => x.EntityStatus == EntityStatus.Active)
        .ToListAsync();

    public virtual async Task<T?> GetByIdAsync(Guid id) => await _context.Set<T>()
        .FirstOrDefaultAsync(x => x.Id == id && x.EntityStatus == EntityStatus.Active);

    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }
}
