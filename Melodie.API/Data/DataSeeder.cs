using Melodie.API.Data.Entities;
using Melodie.API.Data.Entities.TrackEntities;

namespace Melodie.API.Data;

public class DataSeeder
{
	public static List<UserEntity> Users { get; set; } = [];
	public static List<ArtistEntity> Artists { get; set; } = [];
	public static List<MusicGenreEntity> MusicGenres { get; set; } = [];
	public static List<ArtistMusicGenreEntity> ArtistMusicGenres { get; set; } = [];
	public static List<TrackEntity> Tracks { get; set; } = [];
	public static List<SingleEntity> Singles { get; set; } = [];
	public static List<SingleTrackEntity> SingleTracks { get; set; } = [];

	static DataSeeder()
	{
		SeedUsers();
		SeedArtists();
		SeedMusicGenres();
		SeedArtistMusicGenres();
		SeedTracks();
		SeedSingles();
		SeedSingleTracks();
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
		];
	}

	private static void SeedArtistMusicGenres()
	{
		ArtistMusicGenres =
		[
			// Three Days Grace
			new() { ArtistId = Artists[0].Id, MusicGenreId = MusicGenres[0].Id },
			new() { ArtistId = Artists[0].Id, MusicGenreId = MusicGenres[1].Id },
			new() { ArtistId = Artists[0].Id, MusicGenreId = MusicGenres[2].Id },
			new() { ArtistId = Artists[0].Id, MusicGenreId = MusicGenres[3].Id },
			// syudou
			new() { ArtistId = Artists[1].Id, MusicGenreId = MusicGenres[4].Id },
			// Gibbs
			new() { ArtistId = Artists[2].Id, MusicGenreId = MusicGenres[5].Id },
			// Ashton Irwin
			new() { ArtistId = Artists[3].Id, MusicGenreId = MusicGenres[6].Id },
			new() { ArtistId = Artists[3].Id, MusicGenreId = MusicGenres[7].Id },
			new() { ArtistId = Artists[3].Id, MusicGenreId = MusicGenres[8].Id },
			new() { ArtistId = Artists[3].Id, MusicGenreId = MusicGenres[9].Id },
			new() { ArtistId = Artists[3].Id, MusicGenreId = MusicGenres[10].Id },
			new() { ArtistId = Artists[3].Id, MusicGenreId = MusicGenres[11].Id }
		];
	}

	private static void SeedTracks()
	{
		Tracks =
		[
			#region Singles
			// Three Days Grace
			new() { Title = "Break" },
			// syudou
			new() { Title = "Inochizuna" },
			new() { Title = "yattyattawa" },
			// Gibbs
			new() { Title = "Nic na mnie"},
			// Ashton Irwin
			new() { Title = "Skinny Skinny" }
			#endregion
		];
	}

	private static void SeedSingles()
	{
		Singles =
		[
			new() { ArtistId = Artists[0].Id, TrackId = Tracks[0].Id, ReleaseDate = new DateOnly(2009, 9, 1) }, // Three Days Grace - Break
			new() { ArtistId = Artists[1].Id, TrackId = Tracks[1].Id, ReleaseDate = new DateOnly(2024, 2, 21) }, // syudou - Inochizuna
			new() { ArtistId = Artists[1].Id, TrackId = Tracks[2].Id, ReleaseDate = new DateOnly(2023, 11, 17) }, // syudou - yattyattawa
			new() { ArtistId = Artists[2].Id, TrackId = Tracks[3].Id, ReleaseDate = new DateOnly(2024, 4, 5) }, // Gibbs - Nic na mnie
			new() { ArtistId = Artists[3].Id, TrackId = Tracks[4].Id, ReleaseDate = new DateOnly(2020, 9, 24) } // Ashton Irwin - Skinny Skinny
		];
	}

	private static void SeedSingleTracks()
	{
		SingleTracks =
		[
			new() { TrackId = Tracks[0].Id, EntityId = Singles[0].Id }, // Three Days Grace - Break
			new() { TrackId = Tracks[1].Id, EntityId = Singles[1].Id }, // syudou - Inochizuna
			new() { TrackId = Tracks[2].Id, EntityId = Singles[2].Id }, // // syudou - yattyattawa
			new() { TrackId = Tracks[3].Id, EntityId = Singles[3].Id }, // Gibbs - Nic na mnie
			new() { TrackId = Tracks[4].Id, EntityId = Singles[4].Id } // Ashton Irwin - Skinny Skinny
		];
	}
}
