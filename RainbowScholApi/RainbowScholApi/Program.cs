using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RainbowScholApi.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RainbowScholApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RainbowScholApiContext") ?? throw new InvalidOperationException("Connection string 'RainbowScholApiContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
