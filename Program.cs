global using C_WebApiTraining.Models;
using C_WebApiTraining.Data;
using C_WebApiTraining.Services.CharacterService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddScoped<ICharacterService, CharacterService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // use the swagger for convienience testing
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); //a middleware redirecting to HTTPS

app.UseAuthorization();

app.MapControllers();

app.Run();
