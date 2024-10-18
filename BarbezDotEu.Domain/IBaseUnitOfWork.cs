// Copyright (c) Hannes Barbez. All rights reserved.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BarbezDotEu.Domain
{
    /// <summary>
    /// Defines a basic unit of work implementation.
    /// </summary>
    /// <typeparam name="BaseEntity">The type of entity.</typeparam>
    public interface IBaseUnitOfWork<BaseEntity>
        where BaseEntity : class
    {
        /// <summary>
        /// Adds a range of entities during this unit of work.
        /// </summary>
        /// <param name="entities">The entities to add.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>A <see cref="Task"/> indicating the status of the operation.</returns>
        Task AddRangeAsync(IEnumerable<BaseEntity> entities, CancellationToken cancellationToken = default);

        /// <summary>
        /// Saves changes.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>The number of items saved.</returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Saves changes.
        /// </summary>
        /// <returns>The number of items saved.</returns>
        int SaveChanges();

        /// <summary>
        /// Performs a raw query and returns its results as <see cref="Task{TResult}"/>.
        /// </summary>
        /// <typeparam name="TEntityRepresentation">The type of entity representation. This can be any class.</typeparam>
        /// <param name="query">The query string.</param>
        /// <param name="parameters">Any parameters referenced in the query string.</param>
        /// <returns>The results of the query in the form of the requested type.</returns>
        Task<IEnumerable<TEntityRepresentation>> RawQueryAsync<TEntityRepresentation>(string query, params object[] parameters)
            where TEntityRepresentation : class;
    }
}
