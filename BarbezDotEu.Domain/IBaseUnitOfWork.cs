// Copyright (c) Hannes Barbez. All rights reserved.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BarbezDotEu.Domain
{
    public interface IBaseUnitOfWork<BaseEntity>
        where BaseEntity : class
    {
        Task AddRangeAsync(IEnumerable<BaseEntity> entities, CancellationToken cancellationToken);

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        int SaveChanges(bool acceptAllChangesOnSuccess);

        int SaveChanges();

        Task<IEnumerable<TEntity>> FromSqlRawAsync<TEntity>(string sql, params object[] parameters)
            where TEntity : class;
    }
}
