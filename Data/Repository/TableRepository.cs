using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Table;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class TableRepository(DataContext context) : ITableRepository
    {
        private readonly DataContext _context = context;

        public async Task CreateAsync(Table entity)
        {
            _context.Tables.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Table>> GetAllAsync()
        {
            return await _context.Tables.ToListAsync();
        }

        public async Task<Table?> GetByIdAsync(int entityId)
        {
            return await _context.Tables.FindAsync(entityId);
        }

        public async Task UpdateAsync(Table entity)
        {
           await _context.SaveChangesAsync();
        }
    }
}