using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Common.Interface
{
    public interface IBaseRepository<Entity> where Entity : class
    {   
        Task CreateAsync (Entity entity);
        Task<Entity?> GetByIdAsync (int entityId);
        Task<IList<Entity>> GetAllAsync();
        
        Task UpdateAsync (Entity entity);
        
        
    }
}