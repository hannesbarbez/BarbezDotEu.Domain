// Copyright (c) Hannes Barbez. All rights reserved.

using System;

namespace BarbezDotEu.Domain
{
    /// <summary>
    /// Defines the blueprint for a basic entity using only an ID property.
    /// </summary>
    /// <typeparam name="TKey">The type of the entity key.</typeparam>
    public interface IBaseEntity<TKey>
        where TKey : IComparable<TKey>, IEquatable<TKey>, IUtf8SpanFormattable
    {
        /// <summary>
        /// Gets the ID of the entity.
        /// </summary>
        TKey Id { get; }
    }
}
