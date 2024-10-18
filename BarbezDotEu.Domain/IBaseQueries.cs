// Copyright (c) Hannes Barbez. All rights reserved.

using System;
using System.Linq;
using System.Threading.Tasks;

namespace BarbezDotEu.Domain
{
    /// <summary>
    /// Defines a blueprint for querying a collection of entities.
    /// </summary>
    /// <typeparam name="TEntity">The entity type that is being queried.</typeparam>
    /// <typeparam name="TDto">The default representation to return an entity as.</typeparam>
    /// <typeparam name="TKey">The key of the entity.</typeparam>
    public interface IBaseQueries<TEntity, TDto, TKey>
        where TEntity : IBaseEntity<TKey>
        where TDto : IIsBaseDto<TEntity, TKey>
        where TKey : IComparable<TKey>, IEquatable<TKey>, IUtf8SpanFormattable
    {
        /// <summary>
        /// Gets an entity by its key.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An entity.</returns>
        Task<TDto> Get(TKey id);

        /// <summary>
        /// Gets a paged queryable collection of entity representations.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="pageSize">The size of one page.</param>
        /// <returns>A collection of entities.</returns>
        IQueryable<TDto> Get(int page, byte pageSize);

        /// <summary>
        /// Gets a queryable collection of entity representations corresponding to a given date time.
        /// </summary>
        /// <param name="dateTime">The <see cref="DateTime"/> to which entity representations correspond.</param>
        /// <returns>A collection of entities.</returns>
        IQueryable<TDto> Get(DateTime dateTime);

        // TODO: Task<bool> Exists(long id);
    }
}
