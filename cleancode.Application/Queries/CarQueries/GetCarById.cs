using cleancode.Application.DTOs;
using cleancode.shared.Abstraction.Application.Queries;

namespace cleancode.Application.Queries.CarQueries
{
    public record GetCarById(int id):IQuery<CarDto>;
    
}
