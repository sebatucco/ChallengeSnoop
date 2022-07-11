using ChallengeSnopp.Core.Entities.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeSnopp.Core.Interface
{
    public interface IBaseRepository<T> where T : Entity
    {
        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> Add(T entity);

        Task<T> Update(T entity);

        Task DeleteByIdAsync(int id);
    }
}
