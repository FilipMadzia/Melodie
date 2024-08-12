using Melodie.API.Data.Entities;
using Melodie.API.Repositories.Shared;

namespace Melodie.API.Repositories;

public class TrackRepository(MelodieAPIContext context) : BaseRepository<TrackEntity>(context) { }