using Microsoft.EntityFrameworkCore;
using minimal_api.DataBase;
using minimal_api.Minimal_Api;
using minimal_api.Services;

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

app.Get();

app.Run();
