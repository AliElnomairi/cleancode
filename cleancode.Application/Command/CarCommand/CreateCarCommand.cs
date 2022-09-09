using cleancode.Application.DTOs;
using cleancode.shared.Abstraction.Application.Commands;

namespace cleancode.Application.Command.CarCommand
{
    public record CreateCarCommand(int id,string name,string color,string year):ICommand<CarDto>;
    
}
