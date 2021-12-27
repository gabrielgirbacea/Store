using Store.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(Guid id);

        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}
