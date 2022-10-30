using cleancode.Application.DTOs;
using cleancode.Application.Repositories;
using cleancode.Domain.Entities;
using cleancode.shared.Abstraction.Application.Queries;


using Mapster;

namespace cleancode.Application.Queries.CarQueries.Handlers
{
    
    internal class GetAllCarsHandler : IQueryHandler<GetAllCars,List<CarDto>>
    {
        private readonly ICarRepository _CarRepo;

        public GetAllCarsHandler(ICarRepository carRepo)
        {
            _CarRepo = carRepo;
        }
        public async Task<List<CarDto>> Handle(GetAllCars request,CancellationToken cancellation)
        {
            var cars = await _CarRepo.GetAllAsync(cancellation);
            return cars.Adapt<IEnumerable<Car>, IEnumerable<CarDto>>().ToList();


        }
    }
}
