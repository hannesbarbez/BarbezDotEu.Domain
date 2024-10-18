// Copyright (c) Hannes Barbez. All rights reserved.

using System;
using System.Linq;

namespace BarbezDotEu.Domain
{
    /// <summary>
    /// Defines a blueprint of a simple repository.
    /// </summary>
    /// <typeparam name="TEntity">The entity type.</typeparam>
    /// <typeparam name="TKey">The key type.</typeparam>
    public interface IBaseRepository<TEntity, TKey>
        where TEntity : IBaseAggregateRoot
        where TKey : IComparable<TKey>, IEquatable<TKey>, IUtf8SpanFormattable
    {
        /// <summary>
        /// A collection of entities that can be queried.
        /// </summary>
        IQueryable<TEntity> Entities { get; }

        /// <summary>
        /// Removes an entity from the collection of entities.
        /// </summary>
        /// <param name="entity"></param>
        void Remove(IBaseEntity<TKey> entity);

        /// <summary>
        /// Removes an entity from the collection of entities.
        /// </summary>
        /// <param name="entity"></param>
        void Add(IBaseEntity<TKey> entity);
    }
}
