using cleancode.Domain.Entities;

namespace cleancode.Application.Repositories
{
    public interface IParkingRepositories : IBaseRepository<Parking>
    {
        public Task<Parking> GetParkingWithCar(int id, CancellationToken cancellation);
    }
}
