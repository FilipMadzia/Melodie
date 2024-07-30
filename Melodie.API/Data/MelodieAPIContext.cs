using Microsoft.EntityFrameworkCore;
using Melodie.API.Data.Entities;

public class MelodieAPIContext(DbContextOptions<MelodieAPIContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Melodie.API.Data.Entities.Single> Singles { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
    public DbSet<Queue> Queues { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .HasOne(x => x.Queue)
            .WithOne(x => x.User)
            .HasForeignKey<Queue>(x => x.UserId);
	}
}
