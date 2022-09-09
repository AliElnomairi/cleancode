using cleancode.Application.DTOs;
using MediatR;
using System.Text.Json.Serialization;
using cleancode.Infrastructure;
using cleancode.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


object value = builder.Services.AddMediatR(typeof(CarDto));
builder.Services.AddControllers()
  .AddJsonOptions(o =>
        o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(o => o.AllowAnyHeader().AllowAnyMethod().WithOrigins("*"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
