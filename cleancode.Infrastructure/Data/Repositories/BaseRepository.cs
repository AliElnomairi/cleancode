using cleancode.Application.Repositories;
using cleancode.shared.Abstraction.Domain;

using Microsoft.EntityFrameworkCore;

namespace cleancode.Infrastructure.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<TEntity> _entity;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _entity = context.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellation)
        {
            var Create = await _entity.AddAsync(entity, cancellation);
            await _context.SaveChangesAsync(cancellation);
            return Create.Entity;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken)
            => await _entity.ToListAsync(cancellationToken);

        public async Task<TEntity> GetByIdAsync(int id, CancellationToken cancellationToken)
            => await _entity.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);

        public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken)
        {
            var updatedEntity = _entity.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return updatedEntity.Entity;
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            _entity.Remove(await _entity.FirstOrDefaultAsync(e => e.Id == id, cancellationToken));
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
