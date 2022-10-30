using cleancode.shared.Abstraction.Application.Commands;
using MediatR;
namespace cleancode.Application.Commands.ParkingCommands
{
    public record DeleteParkingCommand(int id):ICommand<Unit>;
}
