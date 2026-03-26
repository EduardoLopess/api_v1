using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Domain.Interfaces
{
    public interface IBaseRepository <Entity> where Entity : class
    {
        Task<Entity> GetByIdAsync(int entityId);
        Task<IList<Entity>> GetAllAsync();
        Task DeleteAsync(int entityId);
        Task UpdateAsync(Entity entity);
    }
}