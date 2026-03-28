using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Domain.Entities;
using api.Domain.Interfaces;

namespace Data.Repository
{
    public class FlavorRepository : IFlavorRepository
    {
        public Task DeleteAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Flavor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Flavor> GetByIdAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Flavor entity)
        {
            throw new NotImplementedException();
        }
    }
}