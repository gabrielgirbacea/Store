using Store.Core.Entities;
using Store.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Core.Interfaces
{
    public interface IBaseEntityRepository<T> where T : BaseEntity
    {
        Task<T> GetEntityByIdAsync(Guid id);

        Task<T> GetEntityWithSpec(ISpecification<T> spec);

        Task<IReadOnlyList<T>> GetEntitiesAsync();

        Task<IReadOnlyList<T>> GetEntitiesAsync(ISpecification<T> spec);
    }
}
