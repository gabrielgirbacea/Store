using Microsoft.EntityFrameworkCore;
using Store.Core.Entities;
using Store.Core.Interfaces;
using Store.Data.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Infrastructure.Data
{
    public class ProductTypeRepository : IProductTypeRepository
    {
        private readonly StoreContext _context;

        public ProductTypeRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<ProductType> GetProductTypeByIdAsync(Guid id)
        {
            return await _context.ProductTypes.FindAsync(id);
        }

        public async Task<IReadOnlyList<ProductType>> GetProductTypesAsync()
        {
            return await _context.ProductTypes.ToListAsync();
        }
    }
}
