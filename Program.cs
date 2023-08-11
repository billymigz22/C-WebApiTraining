var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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