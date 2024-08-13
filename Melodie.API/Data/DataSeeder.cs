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
			new() { Title = "Break" }
		];
	}

	private static void SeedSingles()
	{
		Singles =
		[
			// Three Days Grace - Break
			new() { TrackId = Tracks[0].Id, ReleaseDate = new DateOnly(2009, 9, 1) }
		];
	}

	private static void SeedSingleTracks()
	{
		SingleTracks =
		[
			// Three Days Grace - Break
			new() { EntityId = Singles[0].Id }
		];
	}
}
