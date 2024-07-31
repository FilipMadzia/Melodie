using Melodie.API.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MelodieAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MelodieAPIContext") ?? throw new InvalidOperationException("Connection string 'MelodieAPIContext' not found.")));

builder.Services.AddTransient<AlbumRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
