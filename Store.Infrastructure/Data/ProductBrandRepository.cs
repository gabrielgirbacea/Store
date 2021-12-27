using Microsoft.EntityFrameworkCore;
using Store.Core.Entities;
using Store.Core.Interfaces;
using Store.Data.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Infrastructure.Data
{
    public class ProductBrandRepository : IProductBrandRepository
    {
        private readonly StoreContext _context;

        public ProductBrandRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<ProductBrand> GetProductBrandByIdAsync(Guid id)
        {
            return await _context.ProductBrands.FindAsync(id);
        }

        public async Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync()
        {
            return await _context.ProductBrands.ToListAsync();
        }
    }
}
