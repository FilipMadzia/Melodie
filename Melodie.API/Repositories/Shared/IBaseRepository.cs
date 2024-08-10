﻿namespace Melodie.API.Repositories.Shared;

public interface IBaseRepository<T> where T : class
{
    /// <returns>All entities where EntityStatus is Active</returns>
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetById(Guid id);
}