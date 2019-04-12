using Ecom.Domain.Entities.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Contracts.Factories
{
    public interface IEntityFactory<T> where T:BaseEntity
    {
        Task<bool> CreateAsync(T entity);
        Task<T> GetAsync(int id);
        Task<bool> RemoveAsync(int id);
        Task<ICollection<T>> GetAsync();
    }
}
