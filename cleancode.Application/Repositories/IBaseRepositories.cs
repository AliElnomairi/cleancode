using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode.Application.Repositories
{
    public interface IBaseRepositories<T> where T : class 
    {
        Task<T> AddAsync(T entity, CancellationToken cancellation);
        Task<T> GetById(int id, CancellationToken cancellation);
        Task<IEnumerable<T>> GetAllAsyn(CancellationToken cancellation);
        Task DeleteByIdAsync(int id,CancellationToken cancellation);
        Task<T> Update(T entity, CancellationToken cancellation);

    }
    
}
