using cleancode.Application.DTOs;
using cleancode.Application.Repositories;
using cleancode.Domain.Entities;
using cleancode.shared;
using cleancode.shared.Abstraction.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;

namespace cleancode.Application.Commands.ParkingCommands.Handlers
{
    internal class UpdateParkingHandler : ICommandHandler<UpdateParkingCommand, ParkingDto>
    {
        private readonly ICarRepository _CarRepo;
        private readonly IParkingRepositories _ParkRepo;
        public UpdateParkingHandler(ICarRepository carRepo, IParkingRepositories parkRepo)
        {
            _CarRepo = carRepo;
            _ParkRepo = parkRepo;
        }

        public async Task<Response<ParkingDto>> Handle(UpdateParkingCommand request, CancellationToken cancellationToken)
        {
            var (id,name, CarId) = request;
            var Parking = await _ParkRepo.GetParkingWithCar(id, cancellationToken);
            if(CarId is not null)
            {
                var newCar = new List<Car>();
                foreach (var carids in CarId)
                    newCar.Add(await _CarRepo.GetByIdAsync(carids, cancellationToken));
                Parking.UpdateCar(newCar);
            }
            var UpdateParking = await _ParkRepo.UpdateAsync(Parking,cancellationToken);
            return Response.Success(UpdateParking.Adapt<Parking, ParkingDto>(), "Update Parking" + UpdateParking.Name);
        }
    }
}
