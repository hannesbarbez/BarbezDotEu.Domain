// Copyright (c) Hannes Barbez. All rights reserved.

using System;
using System.Linq;

namespace BarbezDotEu.Domain
{
    public interface IRepository<TEntity, TKey>
        where TEntity : IBaseAggregateRoot
        where TKey : IComparable<TKey>, IEquatable<TKey>, IUtf8SpanFormattable
    {
        IQueryable<TEntity> Entities { get; }

        void Remove(IBaseEntity<TKey> entity);

        void Add(IBaseEntity<TKey> entity);
    }
}
