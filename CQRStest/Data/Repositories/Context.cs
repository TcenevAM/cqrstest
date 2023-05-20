using CQRStest.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRStest.Data.Repositories;

public class Context : DbContext
{
    public Context(DbContextOptions options) : base(options) { }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Library> Libraries { get; set; }
}