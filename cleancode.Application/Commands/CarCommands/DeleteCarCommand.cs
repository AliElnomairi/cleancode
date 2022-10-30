
using cleancode.shared.Abstraction.Application.Commands;

using MediatR;

namespace cleancode.Application.Commands.CarCommands
{
    public record DeleteCarCommand(int id):ICommand<Unit>;
   
}
