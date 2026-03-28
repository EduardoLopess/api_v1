using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Domain.Entities;
using Domain.Interfaces;

namespace Data.Repository
{
    public class AddonsRepository : IAddonsRepository
    {
        public Task DeleteAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Addons>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Addons> GetByIdAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Addons entity)
        {
            throw new NotImplementedException();
        }
    }
}