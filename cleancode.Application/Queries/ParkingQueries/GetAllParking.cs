using cleancode.Application.DTOs;
using cleancode.shared.Abstraction.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode.Application.Queries.ParkingQueries
{
    public record GetAllParking(): IQuery<List<ParkingDto>>;

}
