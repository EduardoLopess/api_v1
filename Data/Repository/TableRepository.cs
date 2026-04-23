using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Table;

namespace Data.Repository
{
    public class TableRepository : ITableRepository
    {
        public Task CreateAsync(Table entity)
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

        public Task UpdateAsync(int entity)
        {
            throw new NotImplementedException();
        }
    }
}