using Melodie.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Data.Seeders;

public static class MusicGenreEntitySeeder
{
	public static void Seed(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<MusicGenreEntity>().HasData(new List<MusicGenreEntity>
		{
			// Three Days Grace
			new() { Name = "Post-grunge" },
			new() { Name = "Hard rock" },
			new() { Name = "Alternative rock" },
			new() { Name = "Alternative metal" },
			new() { Name = "Nu metal" },
			// syudou
			new() { Name = "J-Pop"},
			// Gibbs
			new() { Name = "Hip-hop" },
			// Ashton Irwni
			new() { Name = "Pop rock" },
			new() { Name = "Pop" },
			new() { Name = "Pop punk" },
			new() { Name = "Power pop" },
			new() { Name = "Rock" },
			new() { Name = "New wave" }
		});
	}
}
