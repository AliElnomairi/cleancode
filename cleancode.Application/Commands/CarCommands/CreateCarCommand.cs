﻿using cleancode.Application.DTOs;
using cleancode.shared.Abstraction.Application.Commands;

namespace cleancode.Application.Commands.CarCommands
{
    public record CreateCarCommand(string Name, string Color, string Year) : ICommand<CarDto>;
}
