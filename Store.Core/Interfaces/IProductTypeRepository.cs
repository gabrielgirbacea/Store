using Store.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Core.Interfaces
{
    public interface IProductTypeRepository
    {
        Task<ProductType> GetProductTypeByIdAsync(Guid id);

        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}
