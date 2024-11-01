using Melodie.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Data;

public class MelodieApiContext(DbContextOptions<MelodieApiContext> options) : DbContext(options)
{
    public DbSet<UserEntity> UserEntities { get; set; }
    public DbSet<MusicGenreEntity> MusicGenreEntities { get; set; }
}