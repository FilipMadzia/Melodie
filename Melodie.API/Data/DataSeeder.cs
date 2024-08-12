using Melodie.API.Data.Entities;

namespace Melodie.API.Data;

public class DataSeeder
{
	public static List<UserEntity> Users { get; set; } = [];
	public static List<ArtistEntity> Artists { get; set; } = [];
	public static List<MusicGenreEntity> MusicGenres { get; set; } = [];
	public static List<ArtistMusicGenreEntity> ArtistMusicGenres { get; set; } = [];

	static DataSeeder()
	{
		SeedUsers();
		SeedArtists();
		SeedMusicGenres();
		SeedArtistMusicGenres();
	}

	private static void SeedUsers()
	{
		Users =
		[
			new() { Email = "seed@seed", Password = "seed" },
			new() { Email = "seed2@seed2", Password = "seed2" }
		];
	}

	private static void SeedArtists()
	{
		Artists =
		[
			new() { Name = "Three Days Grace" },
			new() { Name = "syudou" },
			new() { Name = "Gibbs" },
			new() { Name = "Ashton Irwin" }
		];
	}

	private static void SeedMusicGenres()
	{
		MusicGenres =
		[
			new() { Name = "Post-grunge" },
			new() { Name = "Hard rock" },
			new() { Name = "Alternative rock" },
			new() { Name = "Alternative metal" }
		];
	}

	private static void SeedArtistMusicGenres()
	{
		ArtistMusicGenres =
		[
			new() { ArtistId = Artists[0].Id, MusicGenreId = MusicGenres[0].Id },
			new() { ArtistId = Artists[0].Id, MusicGenreId = MusicGenres[1].Id },
			new() { ArtistId = Artists[0].Id, MusicGenreId = MusicGenres[2].Id },
			new() { ArtistId = Artists[0].Id, MusicGenreId = MusicGenres[3].Id },
		];
	}
}
