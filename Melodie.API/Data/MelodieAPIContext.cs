using Melodie.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Data;

public class MelodieApiContext(DbContextOptions<MelodieApiContext> options) : DbContext(options)
{
	public DbSet<Album> Albums { get; set; }
	public DbSet<Artist> Artists { get; set; }
	public DbSet<MusicGenre> MusicGenres { get; set; }
	public DbSet<Track> Tracks { get; set; }
	public DbSet<User> Users { get; set; }
}