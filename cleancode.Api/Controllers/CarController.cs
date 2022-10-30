using cleancode.Application.Commands.CarCommands;
using cleancode.Application.DTOs;
using cleancode.Application.Queries.CarQueries;
using cleancode.Domain.Entities;
using cleancode.shared;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace cleancode.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<Response<CarDto>> AddAsync(CreateCarCommand command, CancellationToken cancellation)
            => await _mediator.Send(command, cancellation);
        [HttpGet]
        public async Task<List<CarDto>> Get([FromHeader] GetAllCars query,CancellationToken cancellation)
            => await _mediator.Send(query,cancellation);
        [HttpGet("{id}")]
        public async Task<CarDto> Get([FromHeader] GetCarById query, CancellationToken cancellation)
            =>await _mediator.Send(query, cancellation);
        [HttpPut]
        public async Task<Response<CarDto>> Put( UpdateCarCommand command,CancellationToken cancellation)
            =>await _mediator.Send(command, cancellation);
        [HttpDelete]
        public async Task<Response<Unit>> Delete(DeleteCarCommand command, CancellationToken cancellation)
            => await _mediator.Send(command, cancellation);
    }
}
