using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Data;

public class MelodieApiContext(DbContextOptions<MelodieApiContext> options) : DbContext(options)
{
	
}