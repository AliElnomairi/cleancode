using cleancode.Application.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode.Infrastructure.Data.Repositories
{
    public class BaseRepositories<T> : IBaseRepositories<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _Entity;

        public BaseRepositories(AppDbContext context)
        {
            _context = context;
            _Entity = context.Set<T>();
        }

        public async Task<T> AddAsync(T entity, CancellationToken cancellation)
        {
            var Create = await _Entity.AddAsync(entity, cancellation);
            await _context.SaveChangesAsync(cancellation);
            return  Create.Entity;
        }

        public Task DeleteByIdAsync(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsyn(CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T entity, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }
    }
}
