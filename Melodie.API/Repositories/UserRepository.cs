using Melodie.API.Data.Entities;
using Melodie.API.Data.Enums;
using Melodie.API.Repositories.Shared;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Repositories;

public class UserRepository(MelodieAPIContext context) : BaseRepository<UserEntity>(context)
{
	readonly MelodieAPIContext _context = context;

	public async Task<UserEntity?> GetByEmailAsync(string email) => await _context.Users
		.FirstOrDefaultAsync(x => x.Email == email && x.EntityStatus == EntityStatus.Active);
}
