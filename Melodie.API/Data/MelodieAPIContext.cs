using Microsoft.EntityFrameworkCore;
using Melodie.API.Data.Entities;

public class MelodieAPIContext(DbContextOptions<MelodieAPIContext> options) : DbContext(options)
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<ArtistEntity> Artists { get; set; }
    public DbSet<TrackEntity> Tracks { get; set; }
    public DbSet<AlbumEntity> Albums { get; set; }
    public DbSet<SingleEntity> Singles { get; set; }
    public DbSet<PlaylistEntity> Playlists { get; set; }
    public DbSet<QueueEntity> Queues { get; set; }
    public DbSet<MusicGenreEntity> MusicGenres { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserEntity>()
            .HasOne(x => x.Queue)
            .WithOne(x => x.User)
            .HasForeignKey<QueueEntity>(x => x.UserId);
	}
}
