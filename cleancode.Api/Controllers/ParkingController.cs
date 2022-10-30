using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using cleancode.shared;
using cleancode.Application.DTOs;
using cleancode.Application.Commands.ParkingCommands;

namespace cleancode.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ParkingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<Response<ParkingDto>> Add(CreateParkingCommand command, CancellationToken cancellation)
            => await _mediator.Send(command, cancellation);
        [HttpPut]
        public async Task<Response<ParkingDto>> Update(UpdateParkingCommand command,CancellationToken cancellation)
            =>await _mediator.Send(command, cancellation);
        [HttpDelete]
        public async Task Delete(DeleteParkingCommand command, CancellationToken cancellation)
            => await _mediator.Send(command, cancellation);
    }
}
