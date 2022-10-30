using cleancode.Application.DTOs;
using cleancode.Domain.Entities;
using cleancode.shared.Abstraction.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode.Application.Commands.ParkingCommands
{
    public record UpdateParkingCommand(int id,string name,List<int> CarsId):ICommand<ParkingDto>;
    
}
