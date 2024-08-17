using Melodie.API.Data.Entities;
using Melodie.API.Repositories.Shared;

namespace Melodie.API.Repositories;

public class MusicGenreRepository(MelodieAPIContext context) : BaseRepository<MusicGenreEntity>(context) { }