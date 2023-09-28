using api_project.Controllers;
using api_project.DataBase;
using api_project.Model;
using api_project.Services;
using BenchmarkDotNet.Running;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("Connection");

//dapper
builder.Services.AddScoped<LockDbContext>(option => new LockDbContext(connectionString));

//entity
builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(connectionString));

//services
builder.Services.AddScoped<LockService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
