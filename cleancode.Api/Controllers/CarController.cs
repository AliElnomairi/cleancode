﻿using cleancode.Application.Command.CarCommand;
using cleancode.Application.DTOs;
using cleancode.Domain.Entities;
using cleancode.shared;
using MediatR;
using Microsoft.AspNetCore.Http;
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
        [HttpPost}
        public async Task<Response<CarDto> AddAsync(CreateCarCommand command,CancellationToken cancellation)=>await _mediator.send(command, CancellationToken);
    }
}
