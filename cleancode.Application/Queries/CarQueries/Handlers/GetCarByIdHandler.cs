using cleancode.Application.DTOs;
using cleancode.Application.Repositories;
using cleancode.shared.Abstraction.Application.Queries;
using Mapster;
using cleancode.Domain.Entities;

namespace cleancode.Application.Queries.CarQueries.Handlers
{
    public class GetCarByIdHandler : IQueryHandler<GetCarById, CarDto>
    {
        private readonly ICarRepository _Car;

        public GetCarByIdHandler(ICarRepository car)
        {
            _Car = car;
        }

        public async Task<CarDto> Handle(GetCarById request, CancellationToken cancellation)
        {
            var car = await _Car.GetByIdAsync(request.id, cancellation);
            return car.Adapt<Car, CarDto>();
        }
    }
}
