using cleancode.Application.Repositories;
using cleancode.Domain.Entities;

namespace cleancode.Infrastructure.Data.Repositories
{
    internal class ParkingRepository : BaseRepository<Parking>, IParkingRepositories
    {
        public ParkingRepository(AppDbContext context) : base(context) { }
    }
}
