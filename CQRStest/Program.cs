using CQRStest.Data.Repositories;
using CQRStest.Data.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.AddTransient<IAuthorRepository, AuthorRepository>();
services.AddTransient<IBookRepository, BookRepository>();
services.AddTransient<ILibraryRepository, LibraryRepository>();
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
