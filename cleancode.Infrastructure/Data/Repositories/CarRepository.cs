using cleancode.Application.Repositories;
using cleancode.Domain.Entities;

namespace cleancode.Infrastructure.Data.Repositories
{
    internal class CarRepository : BaseRepository<Car>, ICarRepository
    {
        public CarRepository(AppDbContext context) : base(context) { }
    }
}
