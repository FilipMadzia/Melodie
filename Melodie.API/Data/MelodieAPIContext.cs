using Microsoft.EntityFrameworkCore;
using Melodie.API.Data.Entities;

public class MelodieAPIContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<ArtistEntity> Artists { get; set; }
    public DbSet<TrackEntity> Tracks { get; set; }
    public DbSet<AlbumEntity> Albums { get; set; }
    public DbSet<SingleEntity> Singles { get; set; }
    public DbSet<PlaylistEntity> Playlists { get; set; }
    public DbSet<QueueEntity> Queues { get; set; }


    public MelodieAPIContext(DbContextOptions<MelodieAPIContext> options) : base(options) { }
}
