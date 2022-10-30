using cleancode.Application.DTOs;
using cleancode.Application.Repositories;
using cleancode.shared;
using cleancode.shared.Abstraction.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using cleancode.Domain.Entities;
using Mapster;

namespace cleancode.Application.Commands.ParkingCommands.Handlers
{
    public class CreateParkingHandler:ICommandHandler<CreateParkingCommand,ParkingDto>
    {
        private readonly IParkingRepositories _ParkingRepo;
        private readonly ICarRepository _CarRepo;

        public CreateParkingHandler(IParkingRepositories parkingRepo, ICarRepository carRepository)
        {
            _ParkingRepo = parkingRepo;
            _CarRepo = carRepository;
        }

        public async Task<Response<ParkingDto>> Handle(CreateParkingCommand request, CancellationToken cancellation)
        {
            var car = new List<Car>();
            foreach (var carid in request.CarId)
            {
                var cars = await _CarRepo.GetByIdAsync(carid, cancellation);
                if (cars == null)
                    throw new Exception("Cars is null");
                car.Add(cars);
            }
            var parking = new Parking(request.Name, car);
            var newParking = await _ParkingRepo.AddAsync(parking, cancellation);
            return Response.Success(newParking.Adapt<Parking,ParkingDto>(),"Sucess create");
                
        }
    }
    
}
