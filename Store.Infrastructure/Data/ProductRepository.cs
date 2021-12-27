using Microsoft.EntityFrameworkCore;
using Store.Core.Entities;
using Store.Core.Interfaces;
using Store.Data.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;

        public ProductRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            return await _context.Products
                .Include(p => p.Type)
                .Include(p => p.Brand)
                .SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Products
                .Include(p => p.Type)
                .Include(p => p.Brand)
                .ToListAsync();
        }
    }
}
