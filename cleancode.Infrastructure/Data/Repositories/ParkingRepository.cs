using cleancode.Application.Repositories;
using cleancode.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace cleancode.Infrastructure.Data.Repositories
{
    internal class ParkingRepository : BaseRepository<Parking>, IParkingRepositories
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Parking> _Parking;
        public ParkingRepository(AppDbContext context) : base(context) 
        {
            _context = context;
            _Parking = _context.Set<Parking>();
        }

        public async Task<Parking> GetParkingWithCar(int id, CancellationToken cancellation)
        => await _Parking.Include(c => c.Cars).FirstOrDefaultAsync(c => c.Id == id, cancellation);
    }
}
