using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Domain.Entities;
using api.Domain.Interfaces;

namespace Data.Repository
{
    public class OrderRepository(DataContext context) : IOrderRepository
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

        public Task<IList<Order>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetByIdAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}