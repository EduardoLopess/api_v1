using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Domain.Entities;
using api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class ProductRepository(DataContext context) : IProductRepository
    {
        private readonly DataContext _context = context;

        public async Task CreateAsync(Product entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Product?> GetByIdAsync(int entityId)
        {
            return await _context.Products.Include(a => a.Addons)
                .SingleOrDefaultAsync(p => p.Id == entityId);

        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}