using Melodie.API.Data.Entities;
using Melodie.API.Repositories.Shared;

namespace Melodie.API.Repositories;

public class PlaylistRepository(MelodieAPIContext context) : BaseRepository<PlaylistEntity>(context) { }