using BowlerAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();  // This allows other sites to grab data from our API

builder.Services.AddDbContext<BowlingLeagueContext>(options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:BowlingLeagueConnection"])  // This sets up SQLite as the database provider for the BowlingLeagueContext
);

builder.Services.AddScoped<IBowlingLeagueRepository, EFBowlingLeagueRepository>(); // Register the EFBowlingLeagueRepository as the implementation for the IBowlingLeagueRepository interface

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(p => p.WithOrigins("http://localhost:3000")); // This allows requests from specific origins, here is the address of our React App

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
