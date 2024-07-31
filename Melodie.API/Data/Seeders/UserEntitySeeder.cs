using Melodie.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Melodie.API.Data.Seeders;

public static class UserEntitySeeder
{
	public static void Seed(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<UserEntity>().HasData(new List<UserEntity>
		{
			new()
			{
				Email = "seed@seed",
				Password = "seed",
			},
			new()
			{
				Email = "seed2@seed2",
				Password = "seed2"
			}
		});
	}
}
