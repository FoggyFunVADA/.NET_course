using CarService.WebAPI.AppConfiguration.ApplicationExtensions;
using CarService.WebAPI.AppConfiguration.ServicesExtensions;
using CarService.Entities;
using CarService.Repository;
using Microsoft.EntityFrameworkCore;
using Serilog;

var configuration = new ConfigurationBuilder()
.AddJsonFile("appsettings.json", optional: false)
.Build();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddSerilogConfiguration(); //Add serilog
builder.Services.AddDbContextConfiguration(configuration);
builder.Services.AddVersioningConfiguration(); //add api versioning
builder.Services.AddControllers();
builder.Services.AddSwaggerConfiguration(); //add swagger configuration

builder.Services.AddScoped<DbContext, Context>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

var app = builder.Build();

app.UseSerilogConfiguration(); 

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerConfiguration(); //use swagger
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

try
{
    Log.Information("Application starting...");
    app.Run();
}
catch (Exception ex)
{
    Log.Error("Application finished with error {error}", ex);
}
finally
{
    Log.Information("Application stopped");
    Log.CloseAndFlush();
}