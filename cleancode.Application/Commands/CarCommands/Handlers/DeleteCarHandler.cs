
using cleancode.Application.Repositories;
using cleancode.shared;
using cleancode.shared.Abstraction.Application.Commands;
using Mapster;
using MediatR;

namespace cleancode.Application.Commands.CarCommands.Handlers
{
    internal class DeleteCarHandler : ICommandHandler<DeleteCarCommand, Unit>
    {
        private readonly ICarRepository _Car;

        public DeleteCarHandler(ICarRepository car)
        {
            _Car = car;
        }

        public async Task<Response<Unit>> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            
             await _Car.DeleteAsync(request.id, cancellationToken);
             return Response.Success(Unit.Value,"Deleted Car");
        }
    }
}
