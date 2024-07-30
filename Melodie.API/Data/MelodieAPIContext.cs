using Microsoft.EntityFrameworkCore;
using Melodie.API.Data.Entities;

public class MelodieAPIContext : DbContext
{
    public MelodieAPIContext(DbContextOptions<MelodieAPIContext> options) : base(options) { }
}
