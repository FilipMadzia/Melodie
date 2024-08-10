using Melodie.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Data.Seeders;

public static class ArtistEntitySeeder
{
	public static void Seed(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<ArtistEntity>().HasData(new List<ArtistEntity>
		{
			new() { Name = "Three Days Grace" },
			new() { Name = "syudou" },
			new() { Name = "Gibbs" },
			new() { Name = "Ashton Irwin" }
		});
	}
}
