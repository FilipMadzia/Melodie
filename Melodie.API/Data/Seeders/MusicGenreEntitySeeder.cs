using Melodie.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Data.Seeders;

public static class MusicGenreEntitySeeder
{
	public static void Seed(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<MusicGenreEntity>().HasData(new List<MusicGenreEntity>
		{
			new() { Name = "Post-grunge" },
			new() { Name = "Hard rock" },
			new() { Name = "Alternative rock" },
			new() { Name = "Alternative metal" },
			new() { Name = "Nu metal" }
		});
	}
}
