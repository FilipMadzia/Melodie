using Melodie.API.Dtos.Artists;
using Melodie.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Melodie.API.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class ArtistsController(
	ArtistRepository _artistRepository,
	AlbumRepository _albumRepository,
	TrackRepository _trackRepository,
	SingleRepository _singleRepository) : ControllerBase
{
	/*[HttpGet]
	public async Task<IActionResult> GetById(Guid id)
	{
		var artistEntity = await _artistRepository.GetByIdAsync(id);

		if(artistEntity == null)
			return NotFound();

		var singles = await _singleRepository.GetByArtistIdAsync(artistEntity.Id);

		var artistDto = new ArtistDto
		{
			Name = artistEntity.Name,
			CoverUrl = $"{artistEntity.Name}.png",
			Singles = singles.Select(x => new ArtistSingleDto
			{
				Title = x.
			})
		};

		return Ok(artistDto);
	}*/
}
