using cleancode.Application.DTOs;
using cleancode.Application.Repositories;
using cleancode.Domain.Entities;
using cleancode.shared;
using cleancode.shared.Abstraction.Application.Commands;
using Mapster;

namespace cleancode.Application.Commands.CarCommands.Handlers
{
    public class UpdateCarHandler : ICommandHandler<UpdateCarCommand, CarDto>
    {
        private readonly ICarRepository _Car;

        public UpdateCarHandler(ICarRepository car)
        {
            _Car = car;
        }

        public async Task<Response<CarDto>> Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
           
            var car=await _Car.GetByIdAsync(request.Id,cancellationToken);

            car.update(request.Name,request.Color,request.Year);

            var updatedCar = await _Car.UpdateAsync(car, cancellationToken);

            return Response.Success(updatedCar.Adapt<Car, CarDto>(), "Updated Car " + updatedCar.Name);

        }
    }
}
