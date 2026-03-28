using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Domain.Entities;
using api.Domain.Interfaces;

namespace Data.Repository
{
    public class AdditionalRepository : IAdditionalRepository
    {
        public Task DeleteAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Additional>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Additional> GetByIdAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Additional entity)
        {
            throw new NotImplementedException();
        }
    }
}