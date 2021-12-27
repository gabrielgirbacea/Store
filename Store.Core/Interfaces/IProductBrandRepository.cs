using Store.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Core.Interfaces
{
    public interface IProductBrandRepository
    {
        Task<ProductBrand> GetProductBrandByIdAsync(Guid id);

        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
    }
}
