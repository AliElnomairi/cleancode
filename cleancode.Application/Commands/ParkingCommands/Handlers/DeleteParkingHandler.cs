using cleancode.Application.DTOs;
using cleancode.Application.Repositories;
using cleancode.shared;
using cleancode.shared.Abstraction.Application.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode.Application.Commands.ParkingCommands.Handlers
{
   
    
    internal class DeleteParkingHandler : ICommandHandler<DeleteParkingCommand, Unit>
    {
        ICarRepository _CarRepo;
        IParkingRepositories _ParkRepo;

        public DeleteParkingHandler(IParkingRepositories parkRepo, ICarRepository carRepo )
        {
            _ParkRepo = parkRepo;
            _CarRepo = carRepo;
        }

        public Task<Response<Unit>> Handle(DeleteParkingCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
