using cleancode.Application.DTOs;
using cleancode.Application.Repositories;
using cleancode.Domain.Entities;
using cleancode.shared;
using cleancode.shared.Abstraction.Application.Commands;

namespace cleancode.Application.Commands.CarCommands.Handlers
{
    internal class CreateCarHandler : ICommandHandler<CreateCarCommand, CarDto>
    {
        private readonly ICarRepository _carRepository;

        public CreateCarHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<Response<CarDto>> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            var (name, color, year) = request;
            var car = new Car(name, color, year);
            var newCar = await _carRepository.AddAsync(car, cancellationToken);
            return Response.Success(
                new CarDto(
                    newCar.Id,
                    newCar.Name,
                    newCar.Color,
                    newCar.Year),
                $"Added car {newCar.Name} ({newCar.Year}, {newCar.Color})");
        }
    }
}
