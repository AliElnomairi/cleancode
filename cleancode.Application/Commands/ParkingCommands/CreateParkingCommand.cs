using cleancode.Application.DTOs;
using cleancode.shared.Abstraction.Application.Commands;

namespace cleancode.Application.Commands.ParkingCommands
{
    public record CreateParkingCommand(string Name,List<int> CarId):ICommand<ParkingDto>;
    
}
