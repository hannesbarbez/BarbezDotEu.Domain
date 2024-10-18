// Copyright (c) Hannes Barbez. All rights reserved.

using System;
using System.Linq;
using System.Threading.Tasks;

namespace BarbezDotEu.Domain
{
    public interface IQueries<TEntity, TDto, TKey>
        where TEntity : IBaseEntity<TKey>
        where TDto : IIsDto<TEntity, TKey>
        where TKey : IComparable<TKey>, IEquatable<TKey>, IUtf8SpanFormattable
    {
        Task<TDto> Get(TKey id);

        IQueryable<TDto> Get(int page, byte pageSize);

        IQueryable<TDto> Get(DateTime entryTime);

        // TODO: Task<bool> Exists(long id);
    }
}
