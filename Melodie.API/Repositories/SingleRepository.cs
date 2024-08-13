using Melodie.API.Data.Entities;
using Melodie.API.Repositories.Shared;

namespace Melodie.API.Repositories;

public class SingleRepository(MelodieAPIContext context) : BaseRepository<SingleEntity>(context) { }