namespace CQRStest.Data.Models;

public class Library : IEntity
{
    public Guid Id { get; set; }
    public required string Address { get; set; }
    public List<Author> Authors { get; set; } = new List<Author>();
    public List<Book> Books { get; set; } = new List<Book>();
}