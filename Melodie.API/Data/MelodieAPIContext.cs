using Microsoft.EntityFrameworkCore;
using Melodie.API.Data.Entities;
using Melodie.API.Data.Entities.LikedEntities;
using Melodie.API.Data.Entities.TrackEntities;
using Melodie.API.Data;

public class MelodieAPIContext(DbContextOptions<MelodieAPIContext> options) : DbContext(options)
{
    public required DbSet<UserEntity> Users { get; set; }
    public required DbSet<ArtistEntity> Artists { get; set; }
	public required DbSet<TrackEntity> Tracks { get; set; }
	public required DbSet<AlbumEntity> Albums { get; set; }
	public required DbSet<SingleEntity> Singles { get; set; }
	public required DbSet<PlaylistEntity> Playlists { get; set; }
	public required DbSet<QueueEntity> Queues { get; set; }
	public required DbSet<MusicGenreEntity> MusicGenres { get; set; }
	public required DbSet<LikedAlbumEntity> LikedAlbums { get; set; }
	public required DbSet<LikedArtistEntity> LikedArtists { get; set; }
	public required DbSet<LikedSingleEntity> LikedSingles { get; set; }
	public required DbSet<LikedTrackEntity> LikedTracks { get; set; }
	public required DbSet<AlbumTrackEntity> AlbumTrack { get; set; }
	public required DbSet<QueueTrackEntity> QueueTrack { get; set; }
	public required DbSet<SingleTrackEntity> SingleTrack { get; set; }
	public required DbSet<ArtistMusicGenreEntity> ArtistMusicGenres { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<UserEntity>()
			.HasData(DataSeeder.Users);

		modelBuilder.Entity<ArtistEntity>()
			.HasData(DataSeeder.Artists);

		modelBuilder.Entity<MusicGenreEntity>()
			.HasData(DataSeeder.MusicGenres);

		modelBuilder.Entity<ArtistMusicGenreEntity>()
			.HasData(DataSeeder.ArtistMusicGenres);

		modelBuilder.Entity<TrackEntity>()
			.HasData(DataSeeder.Tracks);

		modelBuilder.Entity<SingleEntity>()
			.HasData(DataSeeder.Singles);

		modelBuilder.Entity<SingleTrackEntity>()
			.HasData(DataSeeder.SingleTracks);
	}
}
