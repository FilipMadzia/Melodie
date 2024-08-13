﻿using Melodie.API.Data.Entities;

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
}
