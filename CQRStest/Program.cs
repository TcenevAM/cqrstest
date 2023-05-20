using CQRStest.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
var q = builder.Configuration.GetConnectionString("PostgresConnectionString");
services.AddDbContext<Context>(opts =>
    opts.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnectionString")));

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
