using Microsoft.EntityFrameworkCore;
using Melodie.API.Data.Entities;
using Melodie.API.Data.Entities.LikedEntities;
using Melodie.API.Data.Entities.TrackEntities;

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
    public DbSet<LikedAlbumEntity> LikedAlbums { get; set; }
    public DbSet<LikedArtistEntity> LikedArtists { get; set; }
    public DbSet<LikedSingleEntity> LikedSingles { get; set; }
    public DbSet<LikedTrackEntity> LikedTracks { get; set; }
    public DbSet<AlbumTrackEntity> AlbumTrackEntities { get; set; }
    public DbSet<QueueTrackEntity> QueueTrackEntities { get; set; }
    public DbSet<SingleTrackEntity> SingleTrackEntities { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserEntity>()
            .HasOne(x => x.Queue)
            .WithOne(x => x.User)
            .HasForeignKey<QueueEntity>(x => x.UserId);
	}
}
