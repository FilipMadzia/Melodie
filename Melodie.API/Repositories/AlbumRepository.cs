﻿using Melodie.API.Data.Entities;
using Melodie.API.Repositories.Shared;

namespace Melodie.API.Repositories;

public class AlbumRepository(MelodieAPIContext context) : BaseRepository<AlbumEntity>(context) { }
