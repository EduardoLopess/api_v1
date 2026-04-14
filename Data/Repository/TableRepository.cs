using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Domain.Entities;
using api.Domain.Interfaces;

namespace Data.Repository
{
    public class TableRepository : ITableRepository
    {
        public Task CreateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Table>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Table> GetByIdAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Table entity)
        {
            throw new NotImplementedException();
        }
    }
}