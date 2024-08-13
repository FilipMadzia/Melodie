using Melodie.API.Data.Entities;
using Melodie.API.Repositories.Shared;

namespace Melodie.API.Repositories;

public class ArtistRepository(MelodieAPIContext context) : BaseRepository<ArtistEntity>(context) { }
