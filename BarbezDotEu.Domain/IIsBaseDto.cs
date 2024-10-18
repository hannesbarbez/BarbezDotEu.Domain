// Copyright (c) Hannes Barbez. All rights reserved.

using System;

namespace BarbezDotEu.Domain
{
    /// <summary>
    /// Defines what makes an entity representation a DTO.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity this DTO represents.</typeparam>
    /// <typeparam name="TKey">The type of the entity key.</typeparam>
    public interface IIsBaseDto<TEntity, TKey>
        where TEntity : IBaseEntity<TKey>
        where TKey : IComparable<TKey>, IEquatable<TKey>, IUtf8SpanFormattable
    {
    }
}
