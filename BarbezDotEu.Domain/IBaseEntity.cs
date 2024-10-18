// Copyright (c) Hannes Barbez. All rights reserved.

using System;

namespace BarbezDotEu.Domain
{
    public interface IBaseEntity<TKey>
        where TKey : IComparable<TKey>, IEquatable<TKey>, IUtf8SpanFormattable
    {
        TKey Id { get; }
    }
}
