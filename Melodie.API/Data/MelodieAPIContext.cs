using Microsoft.EntityFrameworkCore;
using Melodie.API.Data.Entities;
using Melodie.API.Data.Entities.LikedEntities;
using Melodie.API.Data.Entities.TrackEntities;

public class MelodieAPIContext(DbContextOptions<MelodieAPIContext> options) : DbContext(options)
{
    public DbSet<UserEntity> Users { get; set; } = default!;
    public DbSet<ArtistEntity> Artists { get; set; } = default!;
	public DbSet<TrackEntity> Tracks { get; set; } = default!;
	public DbSet<AlbumEntity> Albums { get; set; } = default!;
	public DbSet<SingleEntity> Singles { get; set; } = default!;
	public DbSet<PlaylistEntity> Playlists { get; set; } = default!;
	public DbSet<QueueEntity> Queues { get; set; } = default!;
	public DbSet<MusicGenreEntity> MusicGenres { get; set; } = default!;
	public DbSet<LikedAlbumEntity> LikedAlbums { get; set; } = default!;
	public DbSet<LikedArtistEntity> LikedArtists { get; set; } = default!;
	public DbSet<LikedSingleEntity> LikedSingles { get; set; } = default!;
	public DbSet<LikedTrackEntity> LikedTracks { get; set; } = default!;
	public DbSet<AlbumTrackEntity> AlbumTrackEntities { get; set; } = default!;
	public DbSet<QueueTrackEntity> QueueTrackEntities { get; set; } = default!;
	public DbSet<SingleTrackEntity> SingleTrackEntities { get; set; } = default!;

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserEntity>()
            .HasOne(x => x.Queue)
            .WithOne(x => x.User)
            .HasForeignKey<QueueEntity>(x => x.UserId);
	}
}
